﻿using System;

public interface IEventObserver
{
    void Process(EventData eventData);
}