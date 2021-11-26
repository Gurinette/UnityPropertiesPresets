    public interface IPropertiesPresets
    {
        public string[] GetPresetsNames();
        public void SetActivePresetIndex(int index);
        public int CurrentActivePresetIndex { get; }
    }