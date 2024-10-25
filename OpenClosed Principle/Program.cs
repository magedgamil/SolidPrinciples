// Using Credit Card Payment
IPaymentMethod creditCardPayment = new CreditCardPayment();
PaymentService paymentService = new PaymentService(creditCardPayment);
paymentService.ProcessPayment();

// Using PayPal Payment
IPaymentMethod payPalPayment = new PayPalPayment();
paymentService = new PaymentService(payPalPayment);
paymentService.ProcessPayment();


// Using Bank Transfer Payment
IPaymentMethod bankTransferPayment = new BankTransferPayment();
paymentService = new PaymentService(bankTransferPayment);
paymentService.ProcessPayment();
