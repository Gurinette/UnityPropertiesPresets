    public interface IPropertiesPresets<out T> where T : Preset
    {
        public string[] GetPresetsNames();
        public void SetActivePresetIndex(int index);
        public int CurrentActivePresetIndex { get; }
    }