using System.Collections.Generic;

namespace PhoneDictionaryLab
{
    public interface IPhoneStorage
    {
        void Add(Phone phone);
        void Remove(Phone phone);
        IEnumerable<Phone> Enumerate();
    }
}