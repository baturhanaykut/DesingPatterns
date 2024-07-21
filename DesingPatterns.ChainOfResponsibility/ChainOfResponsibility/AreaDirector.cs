using DesingPatterns.ChainOfResponsibility.DAL;
using DesingPatterns.ChainOfResponsibility.Models;

namespace DesingPatterns.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para Çekme İşlmei Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para Çekme Tutarı Bölge Direktörünün Günlük Ödeyebileceği Limit Aştığı İçin İşlem Gerçekleştirilemedi, Müşterinin Günlük Maksimum Çekebileceği Tutat 400.000 ₺ olup daha fazlası için birden fazla gün şubeye gelmesi gerekli...";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
