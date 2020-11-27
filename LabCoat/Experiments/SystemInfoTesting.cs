namespace LabCoat.Experiments
{
    using System.Management;

    internal class SystemInfoTesting : IExperiment
    {
        public void Experiment()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            ManagementObjectCollection collection = mos.Get();
            foreach (ManagementObject managementObject in collection)
            {
                foreach (var thing in managementObject.Properties)
                {
                    System.Console.WriteLine(thing.Name);
                    System.Console.WriteLine(thing.Value);
                }
            }
        }

        public string IdentifyExperiment()
        {
            return nameof(SystemInfoTesting);
        }
    }
}