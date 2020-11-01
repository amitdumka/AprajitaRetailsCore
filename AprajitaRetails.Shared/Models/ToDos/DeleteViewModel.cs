﻿using System;

namespace AprajitaRetails.Shared.Models.ToDos
{
    /// <summary>
    /// @Version: 5.0
    /// </summary>
    public class DeleteViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
    }
}
