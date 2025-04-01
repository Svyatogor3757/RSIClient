using System.ComponentModel;

namespace Kuka_Client_2 {

    public class MyDictionary : INotifyPropertyChanged {
        private Dictionary<string, string> dictionary;

        public event PropertyChangedEventHandler? PropertyChanged;
        public bool CollectionChangeEventStopped { get; set; } = false;

        public MyDictionary(IEnumerable<KeyValuePair<string, string>>? collection = null) {
            dictionary = collection?.ToDictionary() ?? new Dictionary<string, string>();
        }

        public string this[string key] {
            get => dictionary.ContainsKey(key) ? dictionary[key] : throw new KeyNotFoundException();
            set {
                if (dictionary.ContainsKey(key)) {
                    dictionary[key] = value;
                    OnPropertyChanged(key);
                } else {
                    dictionary.Add(key, value);
                    OnPropertyChanged(key);
                }
            }
        }

        public void Add(KeyValuePair<string, string> kvp) => this[kvp.Key] = kvp.Value;
        public void Add(string Key, string Value) => this[Key] = Value;
        public void AddRange(IEnumerable<KeyValuePair<string, string>>? array) {
            if (array == null) return;
            //StopedUpdateData = false;
            foreach (var item in array) {
                this[item.Key] = item.Value;
            }
            //StopedUpdateData = true;
        }
        public bool ContainsKey(string Key) => dictionary.ContainsKey(Key);

        public List<KeyValuePair<string, string>> GetItems() => dictionary.ToList();

        protected virtual void OnPropertyChanged(string propertyName) {
            if (!CollectionChangeEventStopped)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static explicit operator Dictionary<string, string>(MyDictionary v) {
            return v.dictionary;
        }
    }
}
