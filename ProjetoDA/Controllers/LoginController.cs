using System.Linq;
using ProjetoDA.Models;

namespace ProjetoDA.Controllers {
    public class LoginController {
        public bool ValidarLogin(string username, string password) {
            using (var db = new ShoppingContext()) {
                var user = db.Users.Where(u => u.Username == username && u.Password == password).First();
                
                if (user == null) {
                    return false;
                }

                SessaoGlobal.UtilizadorLogadoId = 1;
                SessaoGlobal.UtilizadorLogadoNome = username;
                return true;
            }
        }
    }
}