import React, { Component } from 'react';
import { UserInput } from './UserInput';
import HttpService from './services/httpService';

export class AddUser extends React.Component {

    constructor(props) {
        super(props);
        this.state = {};
    }


    render() {
        return (
            <div>
                <UserInput />
            </div>
        )
    }

}