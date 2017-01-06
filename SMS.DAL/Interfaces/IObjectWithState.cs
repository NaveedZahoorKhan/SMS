﻿namespace SMS.DAL.Interfaces
{
    public interface IObjectWithState
    {
        State State { get; set; }
    }
    public enum State
    {
        Unchanged = 0,
        Added = 1,
        Modified = 2,
        Deleted = 3
    }
}
