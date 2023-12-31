﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [ServiceContract]
    public interface IDatabaseService
    {
        [OperationContract]
        void AddUserAccountToDatabase(string nickname, string email, string password);

        [OperationContract]
        UserAccountSet  Login(String nickname, String password);

        [OperationContract]
        void ShowUsersAccounts();

    }
}

