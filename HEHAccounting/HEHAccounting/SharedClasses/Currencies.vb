
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Telerik.WinControls.UI

Module Currencies

    Enum Currency
        LebaneaseLire = 1
        Dollar = 2
    End Enum

    Public Sub FillDropCurrencyFromCurrencyData(drop As RadDropDownList, valueMember As String, showCurrencyName As Boolean)
        drop.ValueMember = valueMember
        If showCurrencyName Then
            drop.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Else
            drop.DisplayMember = IIf(BoolLTRLanguage = True, "LatinSymb", "Symb")
        End If

        drop.DataSource = Currencydata
    End Sub

    Sub ConvertMaskedTextToCurrency(mskTextBox As RadMaskedEditBox, amount As String, currency_id As Currency, Optional show_symbol As Boolean = False)

        Select Case currency_id
            Case Currency.LebaneaseLire

                Dim culture = New CultureInfo("ar-LB")
                If BoolLTRLanguage = True Then
                    culture.NumberFormat.CurrencySymbol = IIf(show_symbol, "L.L", "")
                Else
                    culture.NumberFormat.CurrencySymbol = IIf(show_symbol, "ل.ل", "")
                End If
                mskTextBox.Mask = "C0"
                mskTextBox.MaskType = MaskType.Numeric
                mskTextBox.Culture = culture
                mskTextBox.Text = amount
            Case Currency.Dollar
                Dim culture = New CultureInfo("en-US")
                culture.NumberFormat.CurrencySymbol = IIf(show_symbol, "$", "")
                mskTextBox.Mask = "C3"
                mskTextBox.MaskType = MaskType.Numeric
                mskTextBox.Culture = culture
                mskTextBox.Text = amount
            Case Else
                mskTextBox.Text = amount
        End Select
    End Sub

    Function FormatGridColumnAsCurrency(amount As String, currency_id As Currency, withDecimal As Boolean, Optional show_symbol As Boolean = False) As String

        Select Case currency_id
            Case Currency.LebaneaseLire

                Dim culture = New CultureInfo("ar-LB")
                If BoolLTRLanguage = True Then
                    culture.NumberFormat.CurrencySymbol = IIf(show_symbol, "L.L", "")
                Else
                    culture.NumberFormat.CurrencySymbol = IIf(show_symbol, "ل.ل", "")
                End If

                Return String.Format(culture, "{0:C0}", Val(amount))

            Case Currency.Dollar
                Dim culture = New CultureInfo("en-US")
                culture.NumberFormat.CurrencySymbol = IIf(show_symbol, "$", "")
                Return String.Format(culture, "{0:C}", Val(amount))

            Case Else
                Dim culture = New CultureInfo("en-US")
                culture.NumberFormat.CurrencySymbol = ""
                If withDecimal Then
                    Return String.Format(culture, "{0:C}", Val(amount))
                Else
                    Return String.Format(culture, "{0:C0}", Val(amount))
                End If
        End Select

    End Function
End Module
