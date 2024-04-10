namespace FrechettteZacharyTp4.ViewModels
{
    public class IndexVM
    {
        public ICollection<ClientsInfoVM> clientsInfoVMList { get; set; } = default!;
        public ClientsCreateVM clientsCreateVM { get; set; } = default!;
    }
}
