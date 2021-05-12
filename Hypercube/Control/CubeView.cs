using System;
using System.Collections.Generic;
using System.Diagnostics;
using SourceGrid3;
using SourceGrid3.Cells.Real;
using SourceGrid3Cell = SourceGrid3.Cells.Real.Cell;
using Hypercube.Client.Data;

namespace Hypercube.Control
{
    public partial class CubeView
        : Grid
    {
        public event Action DataLoaded;

        public CubeView() => InitializeComponent();

        private void ClearGrid()
        {
            Rows.Clear();
            Columns.Clear();
        }

        private void SetColumnHeader(int colIndex, string text)
            => this[0, colIndex] = new Header(text);

        private void SetCellValue(int rowIndex, int colIndex, string value)
            => this[rowIndex + 1, colIndex] = new SourceGrid3Cell(value);

        private void Populate((string[] Columns, List<string[]> Rows) data)
        {
            for (int columnIndex = 0; columnIndex < data.Columns.Length; columnIndex++)
                SetColumnHeader(columnIndex, data.Columns[columnIndex]);
            Debug.Print("Columns filled");
            for (int rowIndex = 0; rowIndex < data.Rows.Count; rowIndex++)
                for (int columnIndex = 0; columnIndex < data.Columns.Length; columnIndex++)
                    SetCellValue(rowIndex, columnIndex, data.Rows[rowIndex][columnIndex]);
            Debug.Print("Rows filled");
        }

        public void LoadData(ExtractedData data)
        {
            ClearGrid();
            var dataTable = data.JoinTable();
            ColumnsCount  = dataTable.Columns.Length;
            RowsCount     = dataTable.Rows.Count + 1;
            Populate(dataTable);
            AutoStretchColumnsToFitWidth = true;
            AutoSize();
            Columns.StretchToFit();
        }
    }
}
