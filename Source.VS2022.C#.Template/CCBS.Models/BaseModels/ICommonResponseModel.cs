﻿namespace CCBS.Models
{
    public interface ICommonResponseModel
    {
        #region Public Properties

        string Message { get; set; }

        bool Success { get; set; }

        #endregion Public Properties
    }
}