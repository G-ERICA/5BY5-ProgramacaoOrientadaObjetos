/* 4.Polimorfismo – Sistema de Notificações
Objetivo: implementar o uso de métodos com o mesmo nome, mas comportamentos diferentes.
Descrição:
Crie uma classe base Notificacao com um método Enviar().
Crie classes derivadas Email, SMS e PushNotification.
Cada uma deve sobrescrever o método Enviar() exibindo uma mensagem diferente.
No Main, crie uma lista de Notificacao contendo diferentes tipos e chame o método Enviar() para cada uma. */

using _04;

Notification[] notifications = new Notification[3];

notifications[0] = new SMS();
notifications[1] = new Email();
notifications[2] = new PushNotification();

foreach(var notification in notifications) 
{
    notification.Send("Aqui esta uma nova notificação!");
}
