Public Class Form2

    Private buttonClick As Integer = 0

    Private button1Clicked As Boolean = False
    Private button13Clicked As Boolean = False
    Private button25Clicked As Boolean = False

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click

        buttonClick += 1
        If buttonClick >= 11 Then
            MessageBox.Show("You lose all your chances.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

        Dim image1 As String = "C:\Users\Jerome Steven\Downloads\reality stone(thanos).png"
        Dim originalImage As Image = image.FromFile(image1)
        Dim zoomImage As New Bitmap(Button1.Width, Button1.Height)
        Using g As Graphics = Graphics.FromImage(zoomImage)
            g.DrawImage(originalImage, New Rectangle(0, 0, zoomImage.Width, zoomImage.Height))
        End Using
        Button1.Image = zoomImage
        MessageBox.Show("Great! You found the reality stone.", "Notice")

        button1Clicked = True
        clickedButton()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button10.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Button11.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Button12.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim imgPath As String = "C:\Users\Jerome Steven\Downloads\soul stone(thanos).png"
        Dim originalImage As Image = Image.FromFile(imgPath)
        Dim zoomImage As New Bitmap(Button13.Width, Button13.Height)
        Using g As Graphics = Graphics.FromImage(zoomImage)
            g.DrawImage(originalImage, New Rectangle(0, 0, zoomImage.Width, zoomImage.Height))
        End Using
        Button13.Image = zoomImage
        MessageBox.Show("Great! You found the soul stone.", "Notice")

        button13Clicked = True
        clickedButton()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Button14.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Button15.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Button16.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Button17.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Button18.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Button19.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Button20.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Button21.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Button22.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Button23.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Button24.Image = Image.FromFile("C:\Users\Jerome Steven\Downloads\blackbg.jpg")
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Dim imgPath As String = "C:\Users\Jerome Steven\Downloads\mind stone(thanos).png"
        Dim originalImage As Image = Image.FromFile(imgPath)
        Dim zoomImage As New Bitmap(Button25.Width, Button25.Height)

        Using g As Graphics = Graphics.FromImage(zoomImage)
            g.DrawImage(originalImage, New Rectangle(0, 0, zoomImage.Width, zoomImage.Height))
        End Using
        Button25.Image = zoomImage
        MessageBox.Show("Great! You found the mind stone.", "Notice")

        button25Clicked = True
        clickedButton()
    End Sub

    Private Sub clickedButton()
        If button1Clicked AndAlso button13Clicked AndAlso button25Clicked Then
            MessageBox.Show("Congrats! Thanks for playing.", " VICTORY! ")
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Me.Close()
    End Sub
End Class