//declare var require: any

import React from 'react';
import ReactDOM from 'react-dom';

class Hello extends React.Component {
    render() {
        return (
            <h1>Welcome to React!!!!!!!!</h1>
        );
    }
}

ReactDOM.render(<Hello />, document.getElementById('root'));