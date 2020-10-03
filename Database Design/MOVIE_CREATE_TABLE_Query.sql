CREATE TABLE MOVIE (
MOVIE_NUM                                      INT           NOT NULL    UNIQUE,
MOVIE_TITLE                                    VARCHAR(50)   NOT NULL,
MOVIE_YEAR                                     INT           NOT NULL,
MOVIE_COST                                     NUMERIC(5,2)  NOT NULL,
MOVIE_GENRE                                    VARCHAR(25)   NOT NULL, 
PRICE_CODE                                     INT           DEFAULT NULL,
CONSTRAINT MOVIE_MOVIE_NUM_PK PRIMARY KEY (MOVIE_NUM),
CONSTRAINT MOVIE_PRICE_CODE_FK FOREIGN KEY  (PRICE_CODE) REFERENCES PRICE (PRICE_CODE)
    );