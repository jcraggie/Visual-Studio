Public Class Form1
    Private Sub BikesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BikesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BikesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BikesDBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BikesDBDataSet.Versions' table. You can move, or remove it, as needed.
        Me.VersionsTableAdapter.Fill(Me.BikesDBDataSet.Versions)
        'TODO: This line of code loads data into the 'BikesDBDataSet.Models' table. You can move, or remove it, as needed.
        Me.ModelsTableAdapter.Fill(Me.BikesDBDataSet.Models)
        'TODO: This line of code loads data into the 'BikesDBDataSet.Bikes' table. You can move, or remove it, as needed.
        Me.BikesTableAdapter.Fill(Me.BikesDBDataSet.Bikes)

    End Sub

    Private Sub GetAllToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BikesTableAdapter.GetAll(Me.BikesDBDataSet.Bikes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GetClassicsToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BikesTableAdapter.GetClassics(Me.BikesDBDataSet.Bikes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GetCruisersToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BikesTableAdapter.GetCruisers(Me.BikesDBDataSet.Bikes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GetAllToolStripButton_Click_1(sender As Object, e As EventArgs) Handles GetAllToolStripButton.Click
        Try
            Me.BikesTableAdapter.GetAll(Me.BikesDBDataSet.Bikes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GetClassicsToolStripButton_Click_1(sender As Object, e As EventArgs) Handles GetClassicsToolStripButton.Click
        Try
            Me.BikesTableAdapter.GetClassics(Me.BikesDBDataSet.Bikes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GetCruisersToolStripButton_Click_1(sender As Object, e As EventArgs) Handles GetCruisersToolStripButton.Click
        Try
            Me.BikesTableAdapter.GetCruisers(Me.BikesDBDataSet.Bikes)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
