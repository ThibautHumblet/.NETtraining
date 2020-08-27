import React, { Component } from 'react';
import './App.css';
import Todos from './components/Todos'

class App extends Component {
  state = {
    todos: [
      {
        id: 1,
        title: 'Basic refresh .NET',
        completed: true
      },
      {
        id: 2,
        title: 'Finish thumblet.be website',
        completed: false
      },
      {
        id: 3,
        title: 'Learn React',
        completed: false
      },
    ] 
  }

  markComplete = (id) => {
    this.setState({ todos: this.state.todos.map( todo => {
      if(todo.id === id) {
        todo.completed = !todo.completed
      }
      return todo
    })})
  }

  render() {
    return (
      <div className="App">
        <h1>Thibaut Humblet - Todo List App</h1>
        <Todos todos={this.state.todos} markComplete={this.markComplete}></Todos>
      </div>
    );
  }
  }


export default App;
