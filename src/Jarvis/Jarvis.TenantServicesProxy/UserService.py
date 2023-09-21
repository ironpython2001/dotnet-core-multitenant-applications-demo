import sys
sys.path.append(r'D:\mygithub\dotnet-core-multitenant-applications-demo\src\Jarvis\Jarvis.WebApi\bin\Debug\net7.0')


import clr
#clr.AddReferenceToFileAndPath('D:\\mygithub\\dotnet-core-multitenant-applications-demo\\src\\Jarvis\\Jarvis.WebApi\\bin\\Debug\\net7.0\\Jarvis.Tenant.BluePrints.dll')
#clr.AddReferenceToFileAndPath('D:\\mygithub\\dotnet-core-multitenant-applications-demo\\src\\Jarvis\\Jarvis.WebApi\\bin\\Debug\\net7.0\\Jarvis.DTOs.dll')
clr.AddReferenceToFile('Jarvis.Tenant.BluePrints.dll')
clr.AddReferenceToFile('Jarvis.DTOs.dll')


from System import *
from Jarvis.Tenant.BluePrints import *
from Jarvis.DTOs import *

class UserService(IUserService):
    
    def GetUser(self, username, password):
        if ((username=='test') and (password =='test')):
            u = User()
            u.Id=1
            return u;
            #return clr.Convert(u, Type.GetType('User'))
        else:
            return None;

    def GetAll(self):
        pass
    
    def GetById(self,i):
        pass

