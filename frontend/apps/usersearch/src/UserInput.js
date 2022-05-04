import React, { Component } from 'react';
import HttpService from './services/httpService';

export class UserInput extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            user: {
                givenName: "",
                familyName: "",
                email: "",
                dateOfBirth: "",
                address: "",
                state: "",
                zipCode: ""
            }
        };
        this.httpService = new HttpService();

        this.handleFamilyNameChange = this.handleFamilyNameChange.bind(this);
        this.handleGivenNameChange = this.handleGivenNameChange.bind(this);
        this.handleEmailChange = this.handleEmailChange.bind(this);
        this.handleDateOfBirthChange = this.handleDateOfBirthChange.bind(this);
        this.handleAddressChange = this.handleAddressChange.bind(this);
        this.handleStateChange = this.handleStateChange.bind(this);
        this.handleZipCodeChange = this.handleZipCodeChange.bind(this);
        this.clearForm = this.clearForm.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    async handleSubmit() {
        console.log("user: ", JSON.stringify(this.state.user));
        await this.httpService.post("https://localhost:7062/user", this.state.user);

    }

    handleGivenNameChange(event) {
        this.setState({
            user: {
                givenName: event.target.value,
                familyName: this.state.user.familyName,
                email: this.state.user.email,
                dateOfBirth: this.state.user.dateOfBirth,
                address: this.state.user.address,
                state: this.state.user.state,
                zipCode: this.state.user.zipCode

            }
        });
    }

    handleFamilyNameChange(event) {
        this.setState({
            user: {
                givenName: this.state.user.givenName,
                familyName: event.target.value,
                email: this.state.user.email,
                dateOfBirth: this.state.user.dateOfBirth,
                address: this.state.user.address,
                state: this.state.user.state,
                zipCode: this.state.user.zipCode

            }
        });
    }
    handleEmailChange(event) {
        this.setState({
            user: {
                givenName: this.state.user.givenName,
                familyName: this.state.user.familyName,
                email: event.target.value,
                dateOfBirth: this.state.user.dateOfBirth,
                address: this.state.user.address,
                state: this.state.user.state,
                zipCode: this.state.user.zipCode

            }
        });

    }

    handleDateOfBirthChange(event) {
        this.setState({
            user: {
                givenName: this.state.user.givenName,
                familyName: this.state.user.familyName,
                email: this.state.user.email,
                dateOfBirth: event.target.value,
                address: this.state.user.address,
                state: this.state.user.state,
                zipCode: this.state.user.zipCode

            }
        });

    }

    handleAddressChange(event) {
        this.setState({
            user: {
                givenName: this.state.user.givenName,
                familyName: this.state.user.familyName,
                email: this.state.user.email,
                dateOfBirth: this.state.user.dateOfBirth,
                address: event.target.value,
                state: this.state.user.state,
                zipCode: this.state.user.zipCode

            }
        });
    }

    handleStateChange(event) {
        this.setState({
            user: {
                givenName: this.state.user.givenName,
                familyName: this.state.user.familyName,
                email: this.state.user.email,
                dateOfBirth: this.state.user.dateOfBirth,
                address: this.state.user.address,
                state: event.target.value,
                zipCode: this.state.user.zipCode

            }
        });
    }

    handleZipCodeChange(event) {
        this.setState({
            user: {
                givenName: this.state.user.givenName,
                familyName: this.state.user.familyName,
                email: this.state.user.email,
                dateOfBirth: this.state.user.dateOfBirth,
                address: this.state.user.address,
                state: this.state.user.state,
                zipCode: event.target.value

            }
        });
    }




    clearForm() {


    }

    render() {
        return (
            <div>
                <div className="user-input-form">
                    <label>Given Name </label>
                    <input type="text" value={this.state.user.givenName} onChange={this.handleGivenNameChange} id="givenName" name="givenName" required></input>

                    <label>Family Name </label>
                    <input type="text" value={this.state.user.familyName} onChange={this.handleFamilyNameChange} id="familyName" name="familyName" required></input>

                    <label>Email Address </label>
                    <input type="text" value={this.state.user.email} onChange={this.handleEmailChange} id="email" name="email" required></input>

                    <label>Date of Birth </label>
                    <input type="date" value={this.state.user.dateOfBirth} onChange={this.handleDateOfBirthChange} id="dateOfBirth" name="dateOfBirth" required></input>

                    <label>Address </label>
                    <input type="text" value={this.state.user.adress} onChange={this.handleAddressChange} id="address" name="address" required></input>

                    <label>State </label>
                    <input type="text" value={this.state.user.state} onChange={this.handleStateChange} id="state" name="state" required></input>

                    <label>Zip Code </label>
                    <input type="text" value={this.state.user.zipCode} onChange={this.handleZipCodeChange} id="zipCode" name="zipCode" required></input>
                </div>


                <div className="form-submit">
                    <button type="button" onClick={this.handleSubmit}>Add User</button>
                    <button type="button" onClick={this.clearForm}>Clear Form</button>


                </div>
            </div>
        )
    }

}