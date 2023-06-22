class Time
{
    int _second;
    int _minute;
    int _hour;

    public Time()
    {

    }
    public Time(int second, int minute, int hour)
    {
        if (second >= 0 && second < 60 && minute >= 0 && minute < 60 && hour >= 0 && hour < 24)
        {
            _second = second;
            _minute = minute;
            _hour = hour;
        }
    }
    public int Hour { get { return _hour; } set { if (value < 24 && value >= 0) _hour = value; } }
    public int Minute { get { return _minute; } set { if (value < 60 && value >= 0) _minute = value; } }
    public int Second { get { return _second; } set { if (value < 60 && value >= 0) _second = value; } }
    public string ToString()
    {
        return $"{_hour}:{_minute}:{_second}";
    }
    public void SetTime(int second, int minute, int hour)
    {
        if (second >= 0 && second < 60 && minute >= 0 && minute < 60 && hour >= 0 && hour < 24)
        {
            _second = second;
            _minute = minute;
            _hour = hour;
        }
    }
    public Time NextSecond()
    {
        ++_second;
        if (_second >= 60)
        {
            _second = 0;
            ++_minute;
            if (_minute >= 60)
            {
                _minute = 0;
                ++_hour;
                if (_hour >= 24)
                {
                    _hour = 0;
                }
            }
        }
        return this;
    }
}