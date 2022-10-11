using System;
using System.Net.Http;

HttpClient client = new HttpClient();
Keycloak.Keycloak_Config c = new Keycloak.Keycloak_Config
{
	realm = Environment.GetEnvironmentVariable("keycloak_myclient_realm"),
	auth_server_url = Environment.GetEnvironmentVariable("keycloak_myclient_auth_server_url"),
	resource = Environment.GetEnvironmentVariable("keycloak_myclient_resource"),
	credentials_secret = Environment.GetEnvironmentVariable("keycloak_myclient_credentials_secret")
};

Keycloak.Keycloak_Access_Token token = Keycloak.Keycloak.login(client, c, "email@company.com", "mypw");

Console.WriteLine("Hej!");
