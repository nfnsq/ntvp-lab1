using System.Data;

namespace View
{
    /// <summary>
    /// Класс для добавления строки в таблицу
    /// </summary>
    public static class RowToTableIncreaser
    {
        /// <summary>
        /// Метод добавляет строку данных в таблицу
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table"></param>
        public static void DoAdd(DataRow row, DataTable table)
        {
            table.Rows.Add(row["Surname"], row["Name"], row["Pay amount"]);
        }
    }
}
