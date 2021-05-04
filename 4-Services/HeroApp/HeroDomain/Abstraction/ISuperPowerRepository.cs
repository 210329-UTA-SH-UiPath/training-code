using HeroDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroDomain.Abstraction
{
    public interface ISuperPowerRepository
    {
        IEnumerable<SuperPower> GetSuperPowers();
        SuperPower GetSuperPowerById(int id);
        SuperPower GetSuperPowerByName(string name);
        void AddSuperPower(SuperPower superPower);
        SuperPower UpdateSuperPower(SuperPower superPower);
        void DeleteSuperPower(int id);
    }
}
