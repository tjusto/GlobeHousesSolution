using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataObjects.Common;

namespace DataObjects
{
    public class House : HouseBase
    {
        //Address
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Province { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual Country County { get; set; }
        public virtual float Latitude { get; set; }
        public virtual float Longitude { get; set; }

        //House qualification
        public virtual HouseType Type { get; set; }
        /// <summary>
        /// m2
        /// </summary>
        public virtual int Area { get; set; } 
        /// <summary>
        /// NUMERO DE ASSOALHADAS
        /// </summary>
        public virtual int Rooms { get; set; }
        public virtual int Beds { get; set; }
        public virtual bool Smokers { get; set; }
        public virtual HouseCondition Condition { get; set; }
        public virtual bool AirConditionerAllHouse { get; set; }
        public virtual bool AirConditionerLivingRoom { get; set; }
        public virtual int AirConditionerRoomsNumber { get; set; }
        public virtual HouseCleaning Cleaning { get; set; }
        public virtual HouseTowels Towels { get; set; }
        public virtual bool Pets { get; set; }
        /// <summary>
        /// CARRO PRÓPRIO DISPONIBILIZADO 
        /// </summary>
        public virtual bool CarIncluded { get; set; }
        /// <summary>
        /// OUTROS CONFORTOS OU ATRACTIVOS
        /// </summary>
        public virtual string Notes { get; set; }
        /// <summary>
        /// Pictures 4 max
        /// </summary>
        public virtual ICollection<Media> Pictures { get; set; }
        
        //Insurance
        /// <summary>
        /// SEGURO DE DANOS PRÓPRIOS
        /// </summary>
        public virtual bool OwnDamageInsurance { get; set; }
        /// <summary>
        /// SEGURO DE RECHEIO EM CASO DE ROUBO
        /// </summary>
        public virtual bool HouseholdInsuranceInCaseOfTheft { get; set; }
        /// <summary>
        /// SEGURO DE DANOS PESSOAIS DAS VISITAS EM CASO DE ACIDENTE DENTRO DE SUA CASA
        /// </summary>
        public virtual bool PersonalInjuryAccidentInsurance { get; set; }
        /// <summary>
        /// VISITANTE DESRESPONSABILIZADO DE DANOS EM SUA CASA
        /// </summary>
        public virtual bool ResponsableForHomeDamages { get; set; }
        /// <summary>
        /// VISITANTE TEM QUE FAZER SEGURO DE RECHEIO DE SUA CASA POR DANOS/QUEBRAS/ROUBO 
        /// </summary>
        public virtual bool GuestMandatoryInsuranreForDamageBreakagesTheft { get; set; }
        /// <summary>
        /// VISITANTE TEM QUE FAZER SEGURO DE RECHEIO DE SUA CASA POR DANOS/QUEBRAS/ROUBO ⁪ POR ___ €
        /// </summary>
        public virtual decimal GuestMandatoryInsuranreForDamageBreakagesTheftValue { get; set; }
        /// <summary>
        /// VISITANTE TEM QUE FAZER SEGURO DE DANOS PESSOAIS PRÓPRIOS EM CASO DE ACIDENTE DENTRO DE SUA CASA
        /// </summary>
        public virtual bool GuestMandatoryOwnDamageInsurance { get; set; }

        //Location highlights
        /// <summary>
        /// m2
        /// </summary>
        public virtual decimal DistanceToPublicTransportations { get; set; }
        /// <summary>
        /// m2
        /// </summary>
        public virtual decimal DistanceToDownTown { get; set; }
        /// <summary>
        /// m2
        /// </summary>
        public virtual decimal DistanceToSupermarket { get; set; }
        /// <summary>
        /// m2
        /// </summary>
        public virtual decimal DistanceToRestaurants { get; set; }
        public virtual ICollection<POI> POIs { get; set; }

        //House availability 
        public virtual ICollection<HouseAvailability> Availability { get; set; }

        //House Reservations
        public virtual ICollection<OrderHouseReservation> Reservations { get; set; }

        //House Rating
        public virtual HouseRating Rating { get; set; }
    }
}
