using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Meter
{
    public partial class Form1 : Form
    {
        private string mainFilePath;
        private List<string> additionalFilePaths;
        public Form1()
        {
            InitializeComponent();
            additionalFilePaths = new List<string>();
        }

        //Объединение
        private void MergeExcelFiles(string outputFilePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;

            try
            {
                // Создание нового файла
                Excel.Workbook newWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet newWorksheet = newWorkbook.ActiveSheet;

                int newRow = 1;

                // Открытие основного файла Excel
                Excel.Workbook mainWorkbook = excelApp.Workbooks.Open(mainFilePath);
                Excel.Worksheet mainWorksheet = mainWorkbook.ActiveSheet;
                Excel.Range mainRange = mainWorksheet.UsedRange;

                // Копирование строк из основного файла в новый файл
                Excel.Range sourceRange = mainWorksheet.UsedRange;
                Excel.Range targetRange = newWorksheet.Cells[newRow, 1];

                sourceRange.Copy(targetRange);
                newRow += sourceRange.Rows.Count;

                // Словарь для отслеживания уникальных записей в основном файле
                Dictionary<string, bool> uniqueRecords = new Dictionary<string, bool>();

                // Перебор строк в основном файле и добавление их в словарь
                int mainRowCount = mainRange.Rows.Count;
                int mainColumnCount = mainRange.Columns.Count;

                for (int row = 4; row <= mainRowCount; row++)
                {
                    string uniqueValueC = mainWorksheet.Cells[row, 3].Value.ToString();
                    string uniqueValueD = mainWorksheet.Cells[row, 4].Value.ToString();
                    string uniqueValueS = mainWorksheet.Cells[row, 19].Value.ToString();

                    string uniqueKey = uniqueValueC + uniqueValueD + uniqueValueS;
                    if (!uniqueRecords.ContainsKey(uniqueKey))
                    {
                        uniqueRecords.Add(uniqueKey, true);
                    }
                }

                // Перебор дополнительных файлов Excel
                foreach (string additionalFilePath in additionalFilePaths)
                {
                    Excel.Workbook additionalWorkbook = excelApp.Workbooks.Open(additionalFilePath);
                    Excel.Worksheet additionalWorksheet = additionalWorkbook.ActiveSheet;
                    Excel.Range additionalRange = additionalWorksheet.UsedRange;

                    int rowCount = additionalRange.Rows.Count;
                    int columnCount = additionalRange.Columns.Count;

                    // Перебор строк в дополнительном файле
                    for (int row = 4; row <= rowCount; row++)
                    {
                        string uniqueValueC = additionalWorksheet.Cells[row, 3].Value.ToString();
                        string uniqueValueD = additionalWorksheet.Cells[row, 4].Value.ToString();
                        string uniqueValueS = additionalWorksheet.Cells[row, 19].Value.ToString();

                        string uniqueKey = uniqueValueC + uniqueValueD + uniqueValueS;
                        if (!uniqueRecords.ContainsKey(uniqueKey))
                        {
                            // Добавление уникальной записи в новый файл
                            Excel.Range sourceDataRange = additionalWorksheet.Range[string.Format("A{0}:Z{0}", row)];
                            Excel.Range targetDataRange = newWorksheet.Range[string.Format("A{0}", newRow)];
                            sourceDataRange.Copy(targetDataRange);
                            newRow++;

                            // Добавление записи в словарь уникальных записей
                            uniqueRecords.Add(uniqueKey, true);
                        }
                    }

                    additionalWorkbook.Close();
                }

                // Сохранение изменений в новом файле
                newWorkbook.SaveAs(outputFilePath);
                newWorkbook.Close();

                MessageBox.Show("Файлы успешно объединены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при объединении файлов Excel: " + ex.Message);
            }
            finally
            {
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }

        private void MainFIleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mainFilePath = openFileDialog.FileName;
                mainFileTextBox.Text = mainFilePath;
            }
        }

        private void AdditionalFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string additionalFilePath = openFileDialog.FileName;
                additionalFilePaths.Add(additionalFilePath);
                additionalFilesListBox.Items.Add(additionalFilePath);
            }
        }

        private void AddAdditionalFileButton_Click(object sender, EventArgs e)
        {
            {
                AdditionalFileButton_Click(sender, e);
            }
        }

        private void MergeButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputFilePath = saveFileDialog.FileName;
                MergeExcelFiles(outputFilePath);
            }
        }

        //Разделение

        private string inputFilePath;
        private void SepExcelFiles(string inputFile)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;

            try
            {
                // Открытие исходного файла Excel
                Excel.Workbook mainWorkbook = excelApp.Workbooks.Open(inputFile);
                Excel.Worksheet mainWorksheet = mainWorkbook.ActiveSheet;

                // Получение диапазона данных из исходного файла
                Excel.Range mainRange = mainWorksheet.UsedRange;

                // Получение уникальных значений в столбце E
                Excel.Range uniqueValuesRange = mainWorksheet.Range["E3:E" + mainWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row];

                // Перебор уникальных значений и создание новых файлов
                foreach (Excel.Range cell in uniqueValuesRange)
                {
                    string uniqueValue = cell.Value.ToString();

                    // Создание нового файла
                    Excel.Workbook newWorkbook = excelApp.Workbooks.Add();
                    Excel.Worksheet newWorksheet = newWorkbook.ActiveSheet;

                    // Копирование первых трех строк из исходного файла
                    Excel.Range sourceHeaderRange = mainWorksheet.Range["A1:Z3"];
                    Excel.Range targetHeaderRange = newWorksheet.Range["A1"];
                    sourceHeaderRange.Copy(targetHeaderRange);
                    int newRow = 4;

                    // Перебор строк исходного файла и добавление строк с одинаковыми значениями в ячейках E в новый файл
                    foreach (Excel.Range row in mainRange.Rows)
                    {
                        string currentValue = row.Cells[1, 5].Value.ToString(); // Значение в столбце E

                        if (currentValue == uniqueValue)
                        {
                            row.Copy(newWorksheet.Cells[newRow, 1]);
                            newRow++;
                        }
                    }

                    // Сохранение нового файла с уникальным именем
                    string outputFileName = Path.GetFileNameWithoutExtension(inputFile) + "_" + uniqueValue;
                    string outputFilePath = Path.Combine(Path.GetDirectoryName(inputFile), outputFileName + ".xlsx");
                    newWorkbook.SaveAs(outputFilePath);
                    newWorkbook.Close();
                }

                mainWorkbook.Close();

                MessageBox.Show("Файл успешно разделен на группы!");
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Произошла ошибка при разделении файла Excel: " + ex.Message);
            }
            finally
            {
                // Закрытие приложения Excel
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }

        private void ResFIleButton_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = openFileDialog.FileName;
                ResFileTextBox.Text = inputFilePath;
            }
        }

        private void SepButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputFilePath))
            {
                SepExcelFiles(inputFilePath);

                MessageBox.Show("Файл успешно разделен на группы!");
            }
            else
            {
                MessageBox.Show("Выберите исходный файл!");
            }
        }
    }
}
