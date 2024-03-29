﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LControl_Escolar
{
    public class clsMateria
    {
        clsHConexion contrato = new clsHConexion();
        string StoreProcedure;
        #region "Consultas"
        public DataSet SELECT_Materia(string Id, string nombre)
        {
            DataSet _dataSet = new DataSet();
            //Operador ternario ?
            StoreProcedure = "CALL SP_SELECT_Materia('" + Id.ToString() + "','" + nombre + "');";
            MySqlCommand comando = new MySqlCommand(StoreProcedure, contrato.conexion);
            MySqlDataAdapter _mySqlDataAdapter = new MySqlDataAdapter();
            _mySqlDataAdapter.SelectCommand = comando;
            contrato.Abrir();
            _mySqlDataAdapter.Fill(_dataSet);
            contrato.Cerrar();
            if (_dataSet.Tables[0].Rows.Count != 0)
                return _dataSet;
            else
                return null;

        }
     
        #endregion

        #region "Eliminaciones"
        public Boolean DELETE_Materia(int id)
        {
            StoreProcedure = "CALL SP_DELETE_Materia('" + id + "');";
            MySqlCommand comando = new MySqlCommand(StoreProcedure, contrato.conexion);

            contrato.Abrir();
            try
            {
                comando.ExecuteReader();
                contrato.Cerrar();
                return true;
            }
            catch (Exception)
            {
                contrato.Cerrar();
                return false;
            }
        }
        #endregion

        #region "Actualizaciones"
        public void UPDATE_Materia(int IdMateria,
                                  string Nombre,
                                  int? Creditos)
        {
            StoreProcedure = "CALL SP_UPDATE_Materia(" + IdMateria.ToString() +
                                                    ",'" + Nombre +
                                                    "'," + ((Creditos == null) ? "0" : Creditos.ToString()) + ");";
            MySqlCommand comando = new MySqlCommand(StoreProcedure, contrato.conexion);

            contrato.Abrir();
            comando.ExecuteReader();
            contrato.Cerrar();
        }
        #endregion

        #region "Insertados"
        public void INSERT_Materia(
                               string Nombre,
                               int? Creditos)
        {
            StoreProcedure = "CALL SP_INSERT_Materia('" + Nombre +
                                                    "'," + ((Creditos == null) ? "0" : Creditos.ToString()) + ");";
            MySqlCommand comando = new MySqlCommand(StoreProcedure, contrato.conexion);

            contrato.Abrir();
            comando.ExecuteReader();
            contrato.Cerrar();
        }
        #endregion
    }
}
