﻿using System;
using System.Data;

namespace Validacoes
{
    public class ValidaCEPCNPJ
    {
        static public String cep = "";
        static public String cidade = "";
        static public String estado = "";
        static public String endereco = "";
        static public String bairro = "";
        static public String razao = "";
        // como faço para validar o cnpj
        public static Boolean verificaCNPJ(String CNPJ)
        {
            bool flag = false;
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://www.receitaws.com.br/v1/cnpj/@cnpj".Replace("@cnpj", CNPJ);
                ds.ReadXml(xml);
                razao = ds.Tables[0].Rows[0]["razaoSocial"].ToString();
                flag = true;
            }
            catch (Exception ex)
            {
                razao = "";
            }
            return flag;
        }
        public static Boolean verificaCEP(String CEP)
        {
            bool flag = false;
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
                ds.ReadXml(xml);
                endereco = ds.Tables[0].Rows[0]["logradouro"].ToString();
                bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
                cep = CEP;
                flag = true;
            }
            catch (Exception ex)
            {
                endereco = "";
                bairro = "";
                cidade = "";
                estado = "";
                cep = "";
            }
            return flag;
        }
    }
}
