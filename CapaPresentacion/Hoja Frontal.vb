﻿Public Class Hoja_Frontal

    Private Sub Hoja_Frontal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxUnidad.Items.Add("Unidad de Hematología/Oncología e Inmunología")
        cbxUnidad.Items.Add("Unidad Quirúrgica / Ortopédica Pediátrica")
        cbxUnidad.Items.Add("Unidad de Psiquiatría")
        cbxUnidad.Items.Add("Unidad de Neurología y Neurocirugía")
        cbxUnidad.Items.Add("Unidad de Nefrología/Gastroenterología/Endocrinología")
        cbxUnidad.Items.Add("Unidad Respiratoria")
        cbxUnidad.Items.Add("Unidad Quirúrgica Médica Cardíaca")
        cbxUnidad.Items.Add("Unidad de Cuidado Infantil")
        cbxUnidad.Items.Add("Unidad de Cuidados Intensivos")
        cbxFactorRH.Items.Add("Positivo")
        cbxFactorRH.Items.Add("Negativo")
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim id_paciente, unidad_medica, numero_cama,
      factorrh, fecha_ingreso, fecha_egreso, hora_ingreso,
      hora_egreso, diagnostico_ingreso, diagnostico_egreso As String
        id_paciente = HojadeIngreso.txtCedula.Text
        unidad_medica = cbxUnidad.SelectedItem
        numero_cama = txtCama.Text
        factorrh = cbxFactorRH.SelectedItem
        fecha_ingreso = dtpFechaIngreso.Value.Day & "/" & dtpFechaIngreso.Value.Month & "/" & dtpFechaIngreso.Value.Year
        fecha_egreso = dtpFechaEgreso.Value.Day & "/" & dtpFechaEgreso.Value.Month & "/" & dtpFechaEgreso.Value.Year
        hora_ingreso = dtpHoraIngreso.Value.ToShortTimeString()
        hora_egreso = dtpHoraEgreso.Value.ToShortTimeString()
        diagnostico_ingreso = txtDiagnosticoIn.Text
        diagnostico_egreso = txtDiagnosticoEg.Text

        CapaDatos.Metodos.GuardarHojaFrontal(id_paciente, unidad_medica, numero_cama,
                                         factorrh, fecha_ingreso, fecha_egreso, hora_ingreso,
                                         hora_egreso, diagnostico_ingreso, diagnostico_egreso)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hoja_historia_clínica.Show()
        Me.Hide()

    End Sub


End Class