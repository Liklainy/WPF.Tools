﻿namespace Kanban.Desktop.KanbanBoard.Model.Configuration
{
    public class CardColors
    {
        public CardColors()
        {

        }

        public CardColors(string borderColor, string backgroundColor)
        {
            BorderColor = borderColor;
            BackgroundColor = backgroundColor;
        }

        public string BorderColor { get; set; }

        public string BackgroundColor { get; set; }
    }
}