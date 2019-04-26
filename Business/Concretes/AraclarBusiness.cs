﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Concretes;
using DataAccesLayer.Concretes;

namespace Business.Concretes
{
    public class AraclarBusiness
    {
        public AraclarBusiness()
        {

        }
        public bool AracEkle(Araclar entity)
        {
            try
            {
                bool basarilimi;
                using (var repo = new AraclarRepository())
                {
                    basarilimi = repo.Ekle(entity);
                }
                return basarilimi;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:CustomerBusiness::InsertCustomer::Error occured.", ex);
            }
        }

        public bool AracGuncelle(Araclar entity)
        {
            try
            {
                bool basarilimi;
                using (var repo = new AraclarRepository())
                {
                    basarilimi = repo.Guncelle(entity);
                }
                return basarilimi;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:CustomerBusiness::UpdateCustomer::Error occured.", ex);
            }
        }

        public bool AracIdSil(int ID)
        {
            try
            {
                bool basarilimi;
                using (var repo = new AraclarRepository())
                {
                    basarilimi = repo.IdSil(ID);
                }
                return basarilimi;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:CustomerBusiness::DeleteCustomer::Error occured.", ex);
            }
        }

        public Araclar AracIdSec(int AracId)
        {
            try
            {
                Araclar responseEntitiy;
                using (var repo = new AraclarRepository())
                {
                    responseEntitiy = repo.IdSec(AracId);
                    if (responseEntitiy == null)
                        throw new NullReferenceException("Böyle Bir Araç Yok!");
                }
                return responseEntitiy;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:CustomerBusiness::SelectCustomerById::Error occured.", ex);
            }
        }

        public List<Araclar> AracHepsiniSec()
        {
            var responseEntities = new List<Araclar>();

            try
            {
                using (var repo = new AraclarRepository())
                {
                    foreach (var entity in repo.HepsiniSec())
                    {
                        responseEntities.Add(entity);
                    }
                }
                return responseEntities;
            }
            catch (Exception ex)
            {
                throw new Exception("BusinessLogic:CustomerBusiness::SelectAllCustomers::Error occured.", ex);
            }
        }
    }
}