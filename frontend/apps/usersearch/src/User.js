import React, { Component } from 'react';
import HttpService from './services/httpService';

export class User extends Component {


    constructor(props) {
        super(props);
        this.state = {
            user: {
                id: "",
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

        this.getUser = this.getUser.bind(this);

    }

    componentDidMount() {
        this.getUser().then(() => console.log('retrieve user'));
    }

    async getUser() {
        var user = await this.httpService.get("https://localhost:7062/user/b0af1653-26f1-498b-97dd-3083b305af8b");
        this.setState({
            user: {
                id: user.id,
                givenName: user.givenName,
                familyName: user.familyName,
                email: user.email,
                dateOfBirth: user.dateOfBirth,
                address: user.address,
                state: user.state,
                zipCode: user.zipCode

            }
        });
    }

    render() {
        return (
            <div className="mt-5 d-flex justify-content-left">
                <div>
                    This is User Page.
                    <h3>{this.state.user.id}</h3>
                    <h3>{this.state.user.givenName}</h3>
                    <h3>{this.state.user.familyName}</h3>
                    <h3>{this.state.user.email}</h3>
                    <h3>{this.state.user.dateOfBirth}</h3>
                    <h3>{this.state.user.address}</h3>
                    <h3>{this.state.user.state}</h3>
                    <h3>{this.state.user.zipCode}</h3>
                </div>
            </div>
        )
    }

}