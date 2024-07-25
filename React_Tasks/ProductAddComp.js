import React from 'react'
import { useNavigate } from 'react-router-dom';
import axios from 'axios';
import MainDashboardComp from '../Layout/MainDashboardComp';
import ProductDashboardComp from './ProductDashboardComp';
import { useState } from 'react';

const ProductAddComp = () => {
    const nav =useNavigate()
    const [itemData,setItemData]=useState({
        pname:"",
        price:"",
        company:""
    });
        const inputChangeHandler=(event)=>{
            const {type,name,value}=event.target;
            setItemData({...itemData,[name]: value});

        }
        const addRecord =(event)=>{
            event.preventDefault()
            axios.post(`http://localhost:8888/products`, itemData).then(()=>{
                window.alert("Record added Sucessfully!!");
                nav(1/MainDashboardComp/ProductDashboardComp)
            }).catch((error)=>{})
        }

    return (
        <div>
            <h2>This is ProductAddComp</h2>
            <div className='row'>
            <div className='col-sm-3'></div>
            <div className='col-sm-6'></div>

            
            <form onSubmit={addRecord}>

                <label className='form-label'> Enter Product Name</label>
                <input type='text' name="pname" onChange={inputChangeHandler} value={itemData.pname}></input>

                <label className='form-label'>Enter Product Price</label>
                <input type='number' name='price' onChange={inputChangeHandler} value={itemData.price}></input>

                <label className='form-label'>Enter Product Company</label>

                <input type='text' name='company' onChange={inputChangeHandler} value={itemData.company}></input>

                <button type="submit" className ="btn btn-primary mt-3">SUBMIT</button>


                    
                </form>
                
            
        </div>
        </div>
    )
}

export default ProductAddComp
