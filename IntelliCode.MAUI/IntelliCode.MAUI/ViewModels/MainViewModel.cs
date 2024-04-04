using IntelliCode.MAUI.Models;

namespace IntelliCode.MAUI.ViewModels;
internal class MainViewModel : BaseViewModel
{
    private Person _Person;

    public MainViewModel()
    {
        _Person = new Person();
    }

    public int Id
    {
        get
        {
            return _Person.Id;
        }
        set
        {
            if (_Person.Id != value)
            {
                _Person.Id = value;
            }
        }
    }

    public string Name { 
        get
        {
            return _Person.Name;
        } 
        set
        {
            if (_Person.Name != value) 
            {
                _Person.Name = value;
            }
        }
    }

    public string EMail
    {
        get
        {
            return _Person.Email;
        }
        set
        {
            if (_Person.Email != value)
            {
                _Person.Email = value;
            }
        }
    }

    public int Age
    {
        get
        {
            return _Person.Age;
        }
        set
        {
            if (_Person.Age != value)
            {
                _Person.Age = value;
            }
        }
    }

    public DateTime BirthDate
    {
        get
        {
            return _Person.BirthDate;
        }
        set
        {
            if (_Person.BirthDate != value)
            {
                _Person.BirthDate = value;
            }
        }
    }
}