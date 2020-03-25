import React, { useState } from 'react';
import { useHistory } from "react-router-dom";
import { Navbar, Nav, NavItem, NavLink, Collapse, NavbarToggler } from 'reactstrap';

const NavbarMenu = () => {
    const history = useHistory();
    const [isOpen, setIsOpen] = useState(false);
    const toggle = () => setIsOpen(!isOpen);
    function isActive(pathname) {
        const currentPathLocation = history.location.pathname
        return currentPathLocation === pathname;
    }
    return (
        <Navbar color='dark' dark expand="sm">
          <NavbarToggler onClick={toggle} />
          <Collapse isOpen={isOpen} navbar>
            <Nav className='mr-auto' navbar>
              <NavItem active={isActive('/')}>
                <NavLink onClick={() => history.push('/') }>Upcoming Movies</NavLink>
              </NavItem>
              <NavItem active={isActive('/search/')}>
                <NavLink onClick={() => history.push('/search/') }>Search Movies</NavLink>
              </NavItem>             
            </Nav>
          </Collapse>
        </Navbar>
  );
}

export default NavbarMenu;