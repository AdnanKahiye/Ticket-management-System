namespace AspnetCoreMvcFull.Models.ViewModels
{
    public class CustomerRig
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Data { get; set; }
        public string CustomerRigPhone { get; internal set; }
        public string CustomerRigName { get; internal set; }
        public string CustomerRigAddress { get; internal set; }
    }
}
