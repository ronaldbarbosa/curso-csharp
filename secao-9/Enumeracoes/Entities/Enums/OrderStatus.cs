namespace Enumeracoes.Entities.Enums
{
    public enum OrderStatus : int
    {
        // Nos enums, quando há a omissão de valor, que nesse caso é do tipo int, por padrão serão atribuídos valores a partir do 0.
        // Para definir os valores usa-se a sintaxe, por exemplo: Processing = 1, 
        PendingPayment,     
        Processing,
        Shipped,
        Delivered
    }
}