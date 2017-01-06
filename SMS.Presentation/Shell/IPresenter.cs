﻿namespace SMS.Presentation
{
    /// <summary>
    /// Базовый интерфейс для презентаторов
    /// </summary>
    public interface IPresenter<out TView>
    {
        TView View { get; }
    }
}
