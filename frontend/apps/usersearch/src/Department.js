import React,{Component} from 'react';

export class Department extends Component{


    constructor(props){
        super(props);
        this.state={deps:[]}
    }
    // refreshList(){
    //     fetch(process.env.RECT_APP_API+'department')
    //     .then(response=>responce.json())
    //     .then(data=>{
    //         this.setState({deps:data});
    //     })

    
    render(){
        return(
            <div >
                This is Department Page.
            </div>
        )
    }

}