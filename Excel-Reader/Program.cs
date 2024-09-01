using Excel_Reader;
using ClosedXML;
namespace ConsoleApp1
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Set File path
            string filePath = "";
            List<Entry> entries = new List<Entry>();

            

            //Selecting A File
            while (filePath == "")
            {
                using OpenFileDialog Ofd = new OpenFileDialog { Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls|All Files (*.*)|*.*", Title = "Select A File" };
                if (Ofd.ShowDialog() == DialogResult.OK) filePath = Ofd.FileName;
            }

            //Getting Info From Excel File
            using (var workbook = new ClosedXML.Excel.XLWorkbook(filePath)) 
            {
                var worksheet = workbook.Worksheet(1); 
                var range = worksheet.RangeUsed(); 

                foreach (var row in range.RowsUsed().Skip(1))
                {
                    //Adds a New Entry Object To The List
                    entries.Add(new Entry());
                    //Initializes Props
                    entries.Last().ID = row.Cell(1).GetValue<int>();
                    entries.Last().Name = row.Cell(2).GetValue<string>();
                    entries.Last().Role = row.Cell(3).GetValue<string>();
                    entries.Last().Salary = row.Cell(4).GetValue<string>();
                }

                //Legend
                foreach (var cell in range.Row(1).Cells())
                {
                    Console.Write(cell.Value + "\t\t\t");
                }
                Console.WriteLine("");

                //Diplay Entry List
                foreach (Entry entry in entries)
                {
                    entry.DisplayEntry();
                }
                
            }

        }
    }
}
