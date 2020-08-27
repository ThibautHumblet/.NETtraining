import React, { Component } from 'react';
import './App.css';
import Todos from './components/Todos';
import AddTodo from './components/AddTodo';
import Header from './components/layout/Header';
import { v4 as uuidv4} from 'uuid';

class App extends Component {
  state = {
    todos: [
      {
        id: uuidv4(),
        title: 'Basic refresh .NET',
        completed: true
      },
      {
        id: uuidv4(),
        title: 'Finish thumblet.be website',
        completed: false
      },
      {
        id: uuidv4(),
        title: 'Learn React',
        completed: false
      },
    ]
  }

  markComplete = (id) => {
    this.setState({
      todos: this.state.todos.map(todo => {
        if (todo.id === id) {
          todo.completed = !todo.completed
        }
        return todo
      })
    })
  }

  delTodo = (id) => {
    this.setState({ todos: [...this.state.todos.filter(todo => todo.id !== id)] });
  }

  addTodo = (title) => {
    const newTodo = {
      id: uuidv4(),
      title: title,
      completed: false
    }
    this.setState({ todos: [...this.state.todos, newTodo] });
  }

  render() {
    return (
      <div className="App">
        <div className="container">
          <Header></Header>
          <AddTodo addTodo={this.addTodo}></AddTodo>
          <Todos todos={this.state.todos} markComplete={this.markComplete} delTodo={this.delTodo}></Todos>
        </div>
      </div>
    );
  }
}


export default App;
