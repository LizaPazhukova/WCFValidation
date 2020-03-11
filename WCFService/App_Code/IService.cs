using System.ServiceModel;

[ServiceContract]
public interface IService
{
	[OperationContract]
	bool Validate(string name, string password);
}


