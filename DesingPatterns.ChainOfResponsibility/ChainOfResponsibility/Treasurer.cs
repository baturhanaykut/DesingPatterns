using DesingPatterns.ChainOfResponsibility.DAL;
using DesingPatterns.ChainOfResponsibility.Models;

namespace DesingPatterns.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if(req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount=req.Amount.ToString();
                customerProcess.Name=req.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para Çekme İşlmei Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover !=null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount=req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para Çekme Tutarı Veznedarın Günlük Ödeyebileceği Limit Aştığı İçin İşlem Şube Müdür Yardımıcsına Yönlendirildi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
