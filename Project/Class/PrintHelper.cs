using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows;

namespace Project.Class
{
    public static class PrintHelper
    {
        public static void PrintDataGrid(DataGrid dataGrid, string title)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                FlowDocument fd = CreateFlowDocument(dataGrid, title);
                IDocumentPaginatorSource idpSource = fd;
                printDialog.PrintDocument(idpSource.DocumentPaginator, title);
            }
        }

        private static FlowDocument CreateFlowDocument(DataGrid dataGrid, string title)
        {
            FlowDocument fd = new FlowDocument();
            fd.PagePadding = new Thickness(50);
            fd.ColumnWidth = 800;
            fd.Blocks.Add(new Paragraph(new Run(title))
            {
                FontSize = 18,
                FontWeight = FontWeights.Bold,
                TextAlignment = TextAlignment.Center
            });

            Table table = new Table();
            table.CellSpacing = 0;
            table.BorderBrush = Brushes.Black;
            table.BorderThickness = new Thickness(1);
            fd.Blocks.Add(table);

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                table.Columns.Add(new TableColumn());
            }

            TableRowGroup headerRowGroup = new TableRowGroup();
            table.RowGroups.Add(headerRowGroup);
            TableRow headerRow = new TableRow();
            headerRowGroup.Rows.Add(headerRow);

            foreach (var column in dataGrid.Columns)
            {
                headerRow.Cells.Add(new TableCell(new Paragraph(new Run(column.Header.ToString())))
                {
                    FontWeight = FontWeights.Bold,
                    TextAlignment = TextAlignment.Center,
                    BorderBrush = Brushes.Black,
                    BorderThickness = new Thickness(0, 0, 1, 1)
                });
            }

            TableRowGroup dataRowGroup = new TableRowGroup();
            table.RowGroups.Add(dataRowGroup);

            foreach (var item in dataGrid.Items)
            {
                if (item is null)
                {
                    TableRow dataRow = new TableRow();
                    dataRowGroup.Rows.Add(dataRow);

                    foreach (var column in dataGrid.Columns)
                    {
                        var cellContent = column.GetCellContent(item) as TextBlock;
                        dataRow.Cells.Add(new TableCell(new Paragraph(new Run(cellContent.Text)))
                        {
                            BorderBrush = Brushes.Black,
                            BorderThickness = new Thickness(0, 0, 1, 1)
                        });
                    }
                }
            }

            return fd;
        }
    }
}
