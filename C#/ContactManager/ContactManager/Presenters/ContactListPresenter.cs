﻿using ContactManager.Views;
using System.Collections.ObjectModel;
using ContactManager.Model;

namespace ContactManager.Presenters
{
    public class ContactListPresenter : PresenterBase<ContactListView>
    {
        private readonly ApplicationPresenter _applicationPresenter;

        public ContactListPresenter(ApplicationPresenter applicacationPresenter, ContactListView view)
            : base(view, "TabHeader")
        {
            _applicationPresenter = applicacationPresenter;
        }

        public string TabHeader
        {
            get { return "All Contacts"; }
        }

        public void Close()
        {
            _applicationPresenter.CloseTab(this);
        }

        public override bool Equals(object obj)
        {
            return obj != null && GetType() == obj.GetType();
        }

        public ObservableCollection<Contact> AllContacts
        {
            get { return _applicationPresenter.CurrentContacts; }
        }

        public void OpenContact(Contact contact)
        {
            _applicationPresenter.OpenContact(contact);
        }
    }
}