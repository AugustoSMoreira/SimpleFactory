using SimpleFactoryPizzaria.Client;

Start();
static void Start()
{
    Pizzaria.SolicitarPizza();
    Start();
}