import React from "react";
import { Menu, Container, Button } from "semantic-ui-react";
import { Link, NavLink } from "react-router-dom";

interface IProps {
  openCreateForm: () => void;
}

export const NavBar: React.FC<IProps> = ({ openCreateForm }) => {
  return (
    <Menu fixed="top" inverted>
      <Container>
        <Menu.Item header as={NavLink} to="/">
          <img
            src="/assets/logo.ico"
            alt="logo"
            style={{ marginRight: "10px" }}
          />
          Reactivities
        </Menu.Item>
        <Menu.Item name="Activities" as={NavLink} to="/activities" />
        <Menu.Item as={NavLink} to="/createActivity">
          <Button positive content="Create Activity" onClick={openCreateForm} />
        </Menu.Item>
      </Container>
    </Menu>
  );
};
