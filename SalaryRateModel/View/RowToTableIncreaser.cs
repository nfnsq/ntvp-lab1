using System.Data;

namespace View
{
    /// <summary>
    /// Класс для добавления строки в таблицу
    /// </summary>
    public static class RowToTableIncreaser
    {
        public static void DoAdd(DataRow row, DataTable table)
        {
            table.Rows.Add(row["Surname"], row["Name"], row["Pay amount"]);
        }
    }
}
