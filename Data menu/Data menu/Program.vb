Imports System

Module Program
    Sub Main(args As String())
        Dim customerName, customerID, address, postcode As String
        Dim i As Integer = 1
        Dim choice, minuteCost, textCost, dataCost, planCost, minutes, text, data, subtotal, VAT, Grandtotal, phone, PlanCostA, PlanCostB, PlanCostC As Integer

        Console.WriteLine("Enter Customer ID")
        customerID = Console.ReadLine
        Console.WriteLine("Enter Customer Name")
        customerName = Console.ReadLine
        Console.WriteLine("Enter Customer Address")
        address = Console.ReadLine
        Console.WriteLine("Enter Customer postcode")
        postcode = Console.ReadLine
        Console.WriteLine("Enter Customer phone")
        phone = Console.ReadLine

        While i = 1
            Console.WriteLine("Main Menu:-")
            Console.WriteLine("-------------------------------")
            Console.WriteLine("1. 3G Plan")
            Console.WriteLine("2. 4G Plan")
            Console.WriteLine("3. 5G plan")
            Console.WriteLine("4. extra minute")
            Console.WriteLine("5. extra text")
            Console.WriteLine("6. extra data")
            Console.WriteLine("7. for receipt ")
            Console.WriteLine("-------------------------------")

            choice = Console.ReadLine()

            If choice = 1 Then
                Console.WriteLine("you have selected 3G plan")
                PlanCostA = 10
            ElseIf choice = 2 Then
                Console.WriteLine("you have selected 4G plan ")
                PlanCostB = 20
            ElseIf choice = 3 Then
                Console.WriteLine("you have selected 5G plan ")
                PlanCostC = 30
            ElseIf choice = 4 Then
                Console.WriteLine("Number of Minutes used")
                minutes = Console.ReadLine
                If minutes <= 500 Then
                    minuteCost = 0
                ElseIf minutes > 500 Then
                    minuteCost = (minutes - 500) * 20
                End If
            ElseIf choice = 5 Then
                Console.WriteLine("Number of Texts sent")
                text = Console.ReadLine
                If text <= 500 Then
                    textCost = 0
                ElseIf text > 500 Then
                    textCost = (text - 500) * 10
                End If
            ElseIf choice = 6 Then
                Console.WriteLine("Number of MBs of Internet")
                data = Console.ReadLine
                If data <= 500 Then
                    dataCost = 0
                ElseIf data > 500 Then
                    dataCost = (data - 500) * 50
                End If

            ElseIf choice = 7 Then
                i = 2

            ElseIf choice > 7 Or choice < 1 Then
                Console.WriteLine("enter a valid number")


            End If
        End While

        planCost = PlanCostA + PlanCostB + PlanCostC
        subtotal = planCost + minuteCost + textCost + dataCost
        VAT = subtotal * 0.2
        Grandtotal = subtotal + VAT

        Console.WriteLine("-------------------------------")

        Console.WriteLine("----Your bill----")
        Console.WriteLine("customer ID : {0}", customerID)
        Console.WriteLine("Name : {0}", customerName)
        Console.WriteLine("Address: {0}", address)
        Console.WriteLine("Postcode: {0}", postcode)
        Console.WriteLine("Phone: {0}", phone)

        Console.WriteLine("****************************")
        Console.WriteLine("****************************")
        Console.WriteLine("****************************")

        Console.WriteLine("Cost of phone calls made: {0}", minuteCost)
        Console.WriteLine("Cost of texts sent: {0}", textCost)
        Console.WriteLine("Cost of Internet usage: {0}", dataCost)
        Console.WriteLine("Cost of Plan: {0}", planCost)
        Console.WriteLine("sub total: {0}", subtotal)
        Console.WriteLine("VAT:  {0}", VAT)
        Console.WriteLine("Grand total:  {0}", Grandtotal)

    End Sub
End Module
