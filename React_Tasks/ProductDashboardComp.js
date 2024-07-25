import axios from 'axios'
import React ,{ useEffect,useState } from 'react'
import EditIcon from '@mui/icons-material/Edit';
import DeleteIcon from '@mui/icons-material/Delete';
import { Link } from 'react-router-dom';
const ProductDashboardComp = () => {
    const [itemData,setItemData] = useState([]);

    useEffect(()=>{
        fetchData()
    },[])
    

    const fetchData=()=>{
        axios.get('http://localhost:8888/products').then((res)=>{
            setItemData(res.data)

        }).catch((error)=>{})
    }
    const deleteProduct = (id)=>{
        if(window.confirm(`Are you sure to del record with id: ${id}`)){
            axios.delete(`http://localhost:8888/products/${id}`).then(()=>{
                window.alert("Record Delete Successfully");
                fetchData();
            }).catch((errror)=>{})
        }
    }
    return (
        <div>
            <h2>This is ProductDashboardComp</h2>
            <Link to="/MainDashboardComp/productadd" >
            
            <button type="button" className="btn btn-primary mt-3" >ADD</button> </Link>

            
             <table className='table table-hover table-stripped'>
                <thead>
                    <tr className='table-dark'>
                        <th> Sr.No</th><th>Name</th><th>Price</th><th>Company</th><th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    {
                    itemData.length > 0 && itemData.map((val,index)=>{
                        return <tr>
                            <td>{index+1}</td>
                            <td>{val.pname}</td>
                            <td>{val.price}</td>
                            <td>{val.company}</td>
                            <td>
                                <button type='button' className="btn btn-outline-success btn-sm">
                                    <EditIcon ></EditIcon>
                                </button> &nbsp;
                                <button type='button' className="btn btn-outline-danger btn-sm" onClick={()=>{deleteProduct(val.id)}} >
                                    <DeleteIcon  ></DeleteIcon>
                                </button>
                            </td>

                        </tr>
                    
                
                    })
                    }
                </tbody>
            </table>
        </div>
    )
}

export default ProductDashboardComp
