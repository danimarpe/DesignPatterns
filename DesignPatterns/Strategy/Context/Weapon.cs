using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Strategy
{
    public class Weapon
    {
        IThrowStrategy _thrower;
        IThrowStrategy Thrower
        {
            get { return _thrower; }
            set { _thrower = value; }
        }

        public void Throw()
        {
            _thrower.Throw();
        }

        IFireStrategy _trigger;
        IFireStrategy Trigger
        {
            get { return _trigger; }
            set { _trigger = value; }
        }

        IStabStrategy _stabber;
        IStabStrategy Stabber
        {
            get { return _stabber; }
            set { _stabber = value; }
        }

        public Weapon()
        { }

        public void Fire()
        {
            _trigger.Fire();
        }

        public void Stab()
        {
            _stabber.Stab();
        }

        public void RunExample()
        {
            Weapon ninjaStar = new Weapon { Thrower = new ThrowOne() };
            Weapon gun = new Weapon { Trigger = new Shot() };
            Weapon machineGun = new Strategy.Weapon { Trigger = new Burst() };
        }
    }
}