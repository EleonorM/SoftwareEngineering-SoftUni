﻿namespace PetStore.Services
{
    using Models.Toy;

    public interface IToyService
    {
        void BuyFromDistributor(string name, string description, decimal distributorPrice, double profit, int brandId, int categoryId);

        void BuyFromDistributor(AddingToysServiceModel model);

        void SellToyToUser(int userId, int toyId);

        bool Exists(int toyId);
    }
}
