// See https://aka.ms/new-console-template for more information
using DesignPatterns.Bridge.Abstract;
using DesignPatterns.Bridge.Implementation;
using DesignPatterns.Bridge.Interfaces;

IMessageSender emailSender = new EmailSender();
IMessageSender smsSender = new SMSSender();

MessageBridge emailMessage = new EmailMessage(emailSender);
MessageBridge smsMessage = new SMSMessage(smsSender);

emailMessage.Send("This is an email message.");
smsMessage.Send("This is an SMS message.");

Console.ReadKey();