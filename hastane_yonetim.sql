--
-- PostgreSQL database dump
--

-- Dumped from database version 14.1
-- Dumped by pg_dump version 14.1

-- Started on 2021-12-20 11:57:35

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 259 (class 1255 OID 16848)
-- Name: acil_servis_hasta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.acil_servis_hasta() RETURNS trigger
    LANGUAGE plpgsql
    AS $$declare 
hastaAdi  varchar;
hastaSoyadi varchar;
hastaTc varchar;
begin
hastaTc := (select hasta_tc from hasta_bilgileri where hasta_tc=NEW.hasta_tc);
if hastaTc=NEW.hasta_tc then
hastaAdi := (select hasta_adi from hasta_bilgileri where hasta_tc = NEW.hasta_tc);
hastaSoyadi := (select hasta_soyadi from hasta_bilgileri where hasta_tc = NEW.hasta_tc);
if hastaAdi!=NEW.hasta_adi then
raise exception 'Tc no veya ad-soyad yanlıştır';
end if;
if hastaSoyadi!=NEW.hasta_soyadi then
raise exception 'Tc no veya ad-soyad yanlıştır';
end if;
return new;
else
insert into hasta_bilgileri (hasta_adi,hasta_soyadi,hasta_tc) values (NEW.hasta_adi,NEW.hasta_soyadi,NEW.hasta_tc);
return new;
end if;
end;$$;


ALTER FUNCTION public.acil_servis_hasta() OWNER TO postgres;

--
-- TOC entry 258 (class 1255 OID 16846)
-- Name: acil_servis_yatak(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.acil_servis_yatak() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update acil_servis_bos_yatak set bos_yatak_sayisi = bos_yatak_sayisi - 1;
return new;
end;
$$;


ALTER FUNCTION public.acil_servis_yatak() OWNER TO postgres;

--
-- TOC entry 245 (class 1255 OID 16750)
-- Name: ameliyat_ekle(integer, integer, character varying, integer, bigint); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.ameliyat_ekle(IN randevu_id integer, IN ameliyat_turu integer, IN ameliyat_tarih character varying, IN ameliyathane_no integer, IN ameliyat_ucret bigint)
    LANGUAGE plpgsql
    AS $$
begin
insert into ameliyathane_bilgileri (randevu_id,ameliyat_id,ameliyat_tarih,ameliyathane_no ,ucret) values (randevu_id,ameliyat_turu,ameliyat_tarih,ameliyathane_no,ameliyat_ucret);
end;
$$;


ALTER PROCEDURE public.ameliyat_ekle(IN randevu_id integer, IN ameliyat_turu integer, IN ameliyat_tarih character varying, IN ameliyathane_no integer, IN ameliyat_ucret bigint) OWNER TO postgres;

--
-- TOC entry 252 (class 1255 OID 16753)
-- Name: ameliyat_sil(integer); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.ameliyat_sil(IN ameliyat_id_sil integer)
    LANGUAGE plpgsql
    AS $$
begin
 delete from ameliyathane_bilgileri where id=ameliyat_id_sil;
end;
$$;


ALTER PROCEDURE public.ameliyat_sil(IN ameliyat_id_sil integer) OWNER TO postgres;

--
-- TOC entry 257 (class 1255 OID 16799)
-- Name: ameliyat_ucret_ekle(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.ameliyat_ucret_ekle() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
declare
hastaTc varchar;
hastaId integer;
begin
hastaTc := (select hasta_tc from randevu where id=NEW.randevu_id);
hastaId := (select id from hasta_bilgileri where hasta_tc = hastaTc);
update fatura_bilgileri set toplam_tutar=toplam_tutar+NEW.ucret where hasta_id = hastaId;
return new;
end;
$$;


ALTER FUNCTION public.ameliyat_ucret_ekle() OWNER TO postgres;

--
-- TOC entry 256 (class 1255 OID 16794)
-- Name: fatura_ekle(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.fatura_ekle() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
Declare
yeni_fiyat integer;
begin
yeni_fiyat := (select fiyat from ilac_bilgileri where id=NEW.istenilen_ilac_id);
update fatura_bilgileri set toplam_tutar= yeni_fiyat+toplam_tutar where hasta_id = NEW.hasta_id;
return new;
end;
$$;


ALTER FUNCTION public.fatura_ekle() OWNER TO postgres;

--
-- TOC entry 255 (class 1255 OID 16796)
-- Name: fatura_olustur(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.fatura_olustur() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
insert into fatura_bilgileri (hasta_id,toplam_tutar) values (NEW.id,0);
return new;
end;
$$;


ALTER FUNCTION public.fatura_olustur() OWNER TO postgres;

--
-- TOC entry 260 (class 1255 OID 16717)
-- Name: hasta_ekle(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.hasta_ekle() RETURNS trigger
    LANGUAGE plpgsql
    AS $$declare 
hastaAdi  varchar;
hastaSoyadi varchar;
hastaTc varchar;
begin
hastaTc := (select hasta_tc from hasta_bilgileri where hasta_tc=NEW.hasta_tc);
if hastaTc=NEW.hasta_tc then
hastaAdi := (select hasta_adi from hasta_bilgileri where hasta_tc = NEW.hasta_tc);
hastaSoyadi := (select hasta_soyadi from hasta_bilgileri where hasta_tc = NEW.hasta_tc);
if hastaAdi!=NEW.hasta_adi then
raise exception 'Tc no veya ad-soyad yanlıştır';
end if;
if hastaSoyadi!=NEW.hasta_soyadi then
raise exception 'Tc no veya ad-soyad yanlıştır';
end if;
return new;
else
insert into hasta_bilgileri (hasta_adi,hasta_soyadi,hasta_tc) values (NEW.hasta_adi,NEW.hasta_soyadi,NEW.hasta_tc);
return new;
end if;
end;$$;


ALTER FUNCTION public.hasta_ekle() OWNER TO postgres;

--
-- TOC entry 239 (class 1255 OID 16894)
-- Name: poliklinik_ucret(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.poliklinik_ucret() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
declare
hastaTc varchar;
hastaId int;
begin
hastaTc := (select hasta_tc from randevu where id = NEW.randevu_id);
hastaId := (Select id from hasta_bilgileri where hasta_tc = hastaTc);
Update fatura_bilgileri set toplam_tutar = toplam_tutar + NEW.muayene_ucret where hasta_id = hastaId;
return new;
end;
$$;


ALTER FUNCTION public.poliklinik_ucret() OWNER TO postgres;

--
-- TOC entry 240 (class 1255 OID 16673)
-- Name: randevu_ekle(character varying, character varying, character varying, integer, integer, character varying); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.randevu_ekle(IN hasta_adi character varying, IN hasta_soyadi character varying, IN hasta_tc character varying, IN doktor_id integer, IN bolum integer, IN tarih character varying)
    LANGUAGE plpgsql
    AS $$
begin
insert into randevu(hasta_adi,hasta_soyadi ,hasta_tc ,doktor_id ,bolum_id,tarih)
values (hasta_adi ,hasta_soyadi ,hasta_tc ,doktor_id ,bolum ,tarih);
end;
$$;


ALTER PROCEDURE public.randevu_ekle(IN hasta_adi character varying, IN hasta_soyadi character varying, IN hasta_tc character varying, IN doktor_id integer, IN bolum integer, IN tarih character varying) OWNER TO postgres;

--
-- TOC entry 241 (class 1255 OID 16662)
-- Name: randevu_sil(integer); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.randevu_sil(IN randevu_id integer)
    LANGUAGE plpgsql
    AS $$
 begin
 delete from randevu where id=randevu_id;
 end;
 $$;


ALTER PROCEDURE public.randevu_sil(IN randevu_id integer) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 230 (class 1259 OID 16826)
-- Name: acil_servis; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.acil_servis (
    id integer NOT NULL,
    hasta_adi character varying(255) NOT NULL,
    hasta_soyadi character varying(255) NOT NULL,
    doktor_id integer NOT NULL,
    gelis_sebebi character varying(255) NOT NULL,
    hasta_tc character varying(11) NOT NULL
);


ALTER TABLE public.acil_servis OWNER TO postgres;

--
-- TOC entry 232 (class 1259 OID 16840)
-- Name: acil_servis_bos_yatak; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.acil_servis_bos_yatak (
    id integer NOT NULL,
    bos_yatak_sayisi integer NOT NULL
);


ALTER TABLE public.acil_servis_bos_yatak OWNER TO postgres;

--
-- TOC entry 231 (class 1259 OID 16839)
-- Name: acil_servis_bos_yatak_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.acil_servis_bos_yatak_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.acil_servis_bos_yatak_id_seq OWNER TO postgres;

--
-- TOC entry 3494 (class 0 OID 0)
-- Dependencies: 231
-- Name: acil_servis_bos_yatak_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.acil_servis_bos_yatak_id_seq OWNED BY public.acil_servis_bos_yatak.id;


--
-- TOC entry 229 (class 1259 OID 16825)
-- Name: acil_servis_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.acil_servis_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.acil_servis_id_seq OWNER TO postgres;

--
-- TOC entry 3495 (class 0 OID 0)
-- Dependencies: 229
-- Name: acil_servis_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.acil_servis_id_seq OWNED BY public.acil_servis.id;


--
-- TOC entry 220 (class 1259 OID 16735)
-- Name: ameliyat_turu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ameliyat_turu (
    id integer NOT NULL,
    ameliyat_turu character varying(255)
);


ALTER TABLE public.ameliyat_turu OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16734)
-- Name: ameliyat_turu_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.ameliyat_turu_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ameliyat_turu_id_seq OWNER TO postgres;

--
-- TOC entry 3496 (class 0 OID 0)
-- Dependencies: 219
-- Name: ameliyat_turu_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.ameliyat_turu_id_seq OWNED BY public.ameliyat_turu.id;


--
-- TOC entry 218 (class 1259 OID 16720)
-- Name: ameliyathane_bilgileri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ameliyathane_bilgileri (
    id integer NOT NULL,
    randevu_id integer,
    ameliyat_tarih character varying(255),
    ameliyathane_no integer,
    ucret bigint,
    ameliyat_id integer
);


ALTER TABLE public.ameliyathane_bilgileri OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16719)
-- Name: ameliyathane_bilgileri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.ameliyathane_bilgileri_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ameliyathane_bilgileri_id_seq OWNER TO postgres;

--
-- TOC entry 3497 (class 0 OID 0)
-- Dependencies: 217
-- Name: ameliyathane_bilgileri_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.ameliyathane_bilgileri_id_seq OWNED BY public.ameliyathane_bilgileri.id;


--
-- TOC entry 212 (class 1259 OID 16676)
-- Name: bolumler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.bolumler (
    id integer NOT NULL,
    bolum_adi character varying(255) NOT NULL
);


ALTER TABLE public.bolumler OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 16675)
-- Name: bolumler_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.bolumler_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.bolumler_id_seq OWNER TO postgres;

--
-- TOC entry 3498 (class 0 OID 0)
-- Dependencies: 211
-- Name: bolumler_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.bolumler_id_seq OWNED BY public.bolumler.id;


--
-- TOC entry 214 (class 1259 OID 16683)
-- Name: doktor_bilgileri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.doktor_bilgileri (
    id integer NOT NULL,
    doktor_adi character varying(255) NOT NULL
);


ALTER TABLE public.doktor_bilgileri OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 16682)
-- Name: doktor_bilgileri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.doktor_bilgileri_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.doktor_bilgileri_id_seq OWNER TO postgres;

--
-- TOC entry 3499 (class 0 OID 0)
-- Dependencies: 213
-- Name: doktor_bilgileri_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.doktor_bilgileri_id_seq OWNED BY public.doktor_bilgileri.id;


--
-- TOC entry 226 (class 1259 OID 16788)
-- Name: fatura_bilgileri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.fatura_bilgileri (
    id integer NOT NULL,
    hasta_id integer NOT NULL,
    toplam_tutar bigint NOT NULL
);


ALTER TABLE public.fatura_bilgileri OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 16787)
-- Name: fatura_bilgileri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.fatura_bilgileri_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.fatura_bilgileri_id_seq OWNER TO postgres;

--
-- TOC entry 3500 (class 0 OID 0)
-- Dependencies: 225
-- Name: fatura_bilgileri_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.fatura_bilgileri_id_seq OWNED BY public.fatura_bilgileri.id;


--
-- TOC entry 216 (class 1259 OID 16702)
-- Name: hasta_bilgileri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.hasta_bilgileri (
    id integer NOT NULL,
    hasta_adi character varying(255) NOT NULL,
    hasta_soyadi character varying(255) NOT NULL,
    hasta_tc character varying(11) NOT NULL
);


ALTER TABLE public.hasta_bilgileri OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16701)
-- Name: hasta_bilgileri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.hasta_bilgileri_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.hasta_bilgileri_id_seq OWNER TO postgres;

--
-- TOC entry 3501 (class 0 OID 0)
-- Dependencies: 215
-- Name: hasta_bilgileri_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.hasta_bilgileri_id_seq OWNED BY public.hasta_bilgileri.id;


--
-- TOC entry 222 (class 1259 OID 16755)
-- Name: ilac_bilgileri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ilac_bilgileri (
    id integer NOT NULL,
    ilac_adi character varying(255) NOT NULL,
    recete_bilgisi character varying(255) NOT NULL,
    stok_sayisi integer NOT NULL,
    fiyat integer NOT NULL
);


ALTER TABLE public.ilac_bilgileri OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 16754)
-- Name: ilac_bilgileri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.ilac_bilgileri_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ilac_bilgileri_id_seq OWNER TO postgres;

--
-- TOC entry 3502 (class 0 OID 0)
-- Dependencies: 221
-- Name: ilac_bilgileri_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.ilac_bilgileri_id_seq OWNED BY public.ilac_bilgileri.id;


--
-- TOC entry 224 (class 1259 OID 16764)
-- Name: ilac_istekleri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ilac_istekleri (
    id integer NOT NULL,
    doktor_id integer NOT NULL,
    hasta_id integer NOT NULL,
    istenilen_ilac_id integer NOT NULL
);


ALTER TABLE public.ilac_istekleri OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 16763)
-- Name: ilac_istekleri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.ilac_istekleri_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ilac_istekleri_id_seq OWNER TO postgres;

--
-- TOC entry 3503 (class 0 OID 0)
-- Dependencies: 223
-- Name: ilac_istekleri_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.ilac_istekleri_id_seq OWNED BY public.ilac_istekleri.id;


--
-- TOC entry 228 (class 1259 OID 16807)
-- Name: kan_istekleri; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.kan_istekleri (
    id integer NOT NULL,
    doktor_id integer NOT NULL,
    hasta_id integer NOT NULL,
    rapor_bilgisi character varying(255) NOT NULL,
    tarih character varying(255) NOT NULL
);


ALTER TABLE public.kan_istekleri OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 16806)
-- Name: kan_istekleri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.kan_istekleri_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.kan_istekleri_id_seq OWNER TO postgres;

--
-- TOC entry 3504 (class 0 OID 0)
-- Dependencies: 227
-- Name: kan_istekleri_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.kan_istekleri_id_seq OWNED BY public.kan_istekleri.id;


--
-- TOC entry 236 (class 1259 OID 16870)
-- Name: klinik; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.klinik (
    id integer NOT NULL,
    randevu_id integer NOT NULL,
    muayene_ucret integer NOT NULL
);


ALTER TABLE public.klinik OWNER TO postgres;

--
-- TOC entry 235 (class 1259 OID 16869)
-- Name: klinik_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.klinik_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.klinik_id_seq OWNER TO postgres;

--
-- TOC entry 3505 (class 0 OID 0)
-- Dependencies: 235
-- Name: klinik_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.klinik_id_seq OWNED BY public.klinik.id;


--
-- TOC entry 234 (class 1259 OID 16851)
-- Name: labaratuvar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.labaratuvar (
    id integer NOT NULL,
    doktor_id integer NOT NULL,
    hasta_id integer NOT NULL,
    sonuc character varying(255) NOT NULL,
    tarih character varying(255) NOT NULL
);


ALTER TABLE public.labaratuvar OWNER TO postgres;

--
-- TOC entry 233 (class 1259 OID 16850)
-- Name: labaratuvar_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.labaratuvar_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.labaratuvar_id_seq OWNER TO postgres;

--
-- TOC entry 3506 (class 0 OID 0)
-- Dependencies: 233
-- Name: labaratuvar_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.labaratuvar_id_seq OWNED BY public.labaratuvar.id;


--
-- TOC entry 238 (class 1259 OID 16877)
-- Name: poliklinik; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.poliklinik (
    id integer NOT NULL,
    randevu_id integer NOT NULL,
    muayene_ucret integer NOT NULL
);


ALTER TABLE public.poliklinik OWNER TO postgres;

--
-- TOC entry 237 (class 1259 OID 16876)
-- Name: poliklinik_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.poliklinik_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.poliklinik_id_seq OWNER TO postgres;

--
-- TOC entry 3507 (class 0 OID 0)
-- Dependencies: 237
-- Name: poliklinik_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.poliklinik_id_seq OWNED BY public.poliklinik.id;


--
-- TOC entry 210 (class 1259 OID 16665)
-- Name: randevu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.randevu (
    id integer NOT NULL,
    hasta_adi character varying(255) NOT NULL,
    hasta_soyadi character varying(255) NOT NULL,
    hasta_tc character varying(11) NOT NULL,
    doktor_id integer NOT NULL,
    bolum_id integer NOT NULL,
    tarih character varying(255) NOT NULL
);


ALTER TABLE public.randevu OWNER TO postgres;

--
-- TOC entry 209 (class 1259 OID 16664)
-- Name: randevu_bilgileri_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.randevu_bilgileri_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.randevu_bilgileri_id_seq OWNER TO postgres;

--
-- TOC entry 3508 (class 0 OID 0)
-- Dependencies: 209
-- Name: randevu_bilgileri_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.randevu_bilgileri_id_seq OWNED BY public.randevu.id;


--
-- TOC entry 3255 (class 2604 OID 16829)
-- Name: acil_servis id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.acil_servis ALTER COLUMN id SET DEFAULT nextval('public.acil_servis_id_seq'::regclass);


--
-- TOC entry 3256 (class 2604 OID 16843)
-- Name: acil_servis_bos_yatak id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.acil_servis_bos_yatak ALTER COLUMN id SET DEFAULT nextval('public.acil_servis_bos_yatak_id_seq'::regclass);


--
-- TOC entry 3250 (class 2604 OID 16738)
-- Name: ameliyat_turu id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ameliyat_turu ALTER COLUMN id SET DEFAULT nextval('public.ameliyat_turu_id_seq'::regclass);


--
-- TOC entry 3249 (class 2604 OID 16723)
-- Name: ameliyathane_bilgileri id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ameliyathane_bilgileri ALTER COLUMN id SET DEFAULT nextval('public.ameliyathane_bilgileri_id_seq'::regclass);


--
-- TOC entry 3246 (class 2604 OID 16679)
-- Name: bolumler id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bolumler ALTER COLUMN id SET DEFAULT nextval('public.bolumler_id_seq'::regclass);


--
-- TOC entry 3247 (class 2604 OID 16686)
-- Name: doktor_bilgileri id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.doktor_bilgileri ALTER COLUMN id SET DEFAULT nextval('public.doktor_bilgileri_id_seq'::regclass);


--
-- TOC entry 3253 (class 2604 OID 16791)
-- Name: fatura_bilgileri id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura_bilgileri ALTER COLUMN id SET DEFAULT nextval('public.fatura_bilgileri_id_seq'::regclass);


--
-- TOC entry 3248 (class 2604 OID 16705)
-- Name: hasta_bilgileri id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hasta_bilgileri ALTER COLUMN id SET DEFAULT nextval('public.hasta_bilgileri_id_seq'::regclass);


--
-- TOC entry 3251 (class 2604 OID 16758)
-- Name: ilac_bilgileri id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac_bilgileri ALTER COLUMN id SET DEFAULT nextval('public.ilac_bilgileri_id_seq'::regclass);


--
-- TOC entry 3252 (class 2604 OID 16767)
-- Name: ilac_istekleri id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac_istekleri ALTER COLUMN id SET DEFAULT nextval('public.ilac_istekleri_id_seq'::regclass);


--
-- TOC entry 3254 (class 2604 OID 16810)
-- Name: kan_istekleri id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kan_istekleri ALTER COLUMN id SET DEFAULT nextval('public.kan_istekleri_id_seq'::regclass);


--
-- TOC entry 3258 (class 2604 OID 16873)
-- Name: klinik id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.klinik ALTER COLUMN id SET DEFAULT nextval('public.klinik_id_seq'::regclass);


--
-- TOC entry 3257 (class 2604 OID 16854)
-- Name: labaratuvar id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.labaratuvar ALTER COLUMN id SET DEFAULT nextval('public.labaratuvar_id_seq'::regclass);


--
-- TOC entry 3259 (class 2604 OID 16880)
-- Name: poliklinik id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.poliklinik ALTER COLUMN id SET DEFAULT nextval('public.poliklinik_id_seq'::regclass);


--
-- TOC entry 3245 (class 2604 OID 16668)
-- Name: randevu id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu ALTER COLUMN id SET DEFAULT nextval('public.randevu_bilgileri_id_seq'::regclass);


--
-- TOC entry 3480 (class 0 OID 16826)
-- Dependencies: 230
-- Data for Name: acil_servis; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.acil_servis (id, hasta_adi, hasta_soyadi, doktor_id, gelis_sebebi, hasta_tc) VALUES (6, 'hasta4', 'hasta4', 1, 'kaza', '65498732115');
INSERT INTO public.acil_servis (id, hasta_adi, hasta_soyadi, doktor_id, gelis_sebebi, hasta_tc) VALUES (7, 'hasta1', 'hasta1', 3, 'kaza', '12345678910');


--
-- TOC entry 3482 (class 0 OID 16840)
-- Dependencies: 232
-- Data for Name: acil_servis_bos_yatak; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.acil_servis_bos_yatak (id, bos_yatak_sayisi) VALUES (1, 196);


--
-- TOC entry 3470 (class 0 OID 16735)
-- Dependencies: 220
-- Data for Name: ameliyat_turu; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.ameliyat_turu (id, ameliyat_turu) VALUES (1, 'estetik');
INSERT INTO public.ameliyat_turu (id, ameliyat_turu) VALUES (2, 'yanık tedavisi');
INSERT INTO public.ameliyat_turu (id, ameliyat_turu) VALUES (3, 'saç ekimi');
INSERT INTO public.ameliyat_turu (id, ameliyat_turu) VALUES (4, 'lazer uygulamaları');


--
-- TOC entry 3468 (class 0 OID 16720)
-- Dependencies: 218
-- Data for Name: ameliyathane_bilgileri; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3462 (class 0 OID 16676)
-- Dependencies: 212
-- Data for Name: bolumler; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.bolumler (id, bolum_adi) VALUES (2, 'doğumhane');
INSERT INTO public.bolumler (id, bolum_adi) VALUES (3, 'klinik');
INSERT INTO public.bolumler (id, bolum_adi) VALUES (4, 'poliklinik');
INSERT INTO public.bolumler (id, bolum_adi) VALUES (6, 'ameliyathane');


--
-- TOC entry 3464 (class 0 OID 16683)
-- Dependencies: 214
-- Data for Name: doktor_bilgileri; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.doktor_bilgileri (id, doktor_adi) VALUES (1, 'doktor1');
INSERT INTO public.doktor_bilgileri (id, doktor_adi) VALUES (2, 'doktor2');
INSERT INTO public.doktor_bilgileri (id, doktor_adi) VALUES (3, 'doktor3');


--
-- TOC entry 3476 (class 0 OID 16788)
-- Dependencies: 226
-- Data for Name: fatura_bilgileri; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.fatura_bilgileri (id, hasta_id, toplam_tutar) VALUES (6, 7, 0);
INSERT INTO public.fatura_bilgileri (id, hasta_id, toplam_tutar) VALUES (7, 8, 0);
INSERT INTO public.fatura_bilgileri (id, hasta_id, toplam_tutar) VALUES (8, 9, 0);
INSERT INTO public.fatura_bilgileri (id, hasta_id, toplam_tutar) VALUES (9, 10, 0);
INSERT INTO public.fatura_bilgileri (id, hasta_id, toplam_tutar) VALUES (10, 11, 0);
INSERT INTO public.fatura_bilgileri (id, hasta_id, toplam_tutar) VALUES (11, 12, 0);


--
-- TOC entry 3466 (class 0 OID 16702)
-- Dependencies: 216
-- Data for Name: hasta_bilgileri; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.hasta_bilgileri (id, hasta_adi, hasta_soyadi, hasta_tc) VALUES (7, 'hasta1', 'hasta1', '12345678910');
INSERT INTO public.hasta_bilgileri (id, hasta_adi, hasta_soyadi, hasta_tc) VALUES (8, 'hasta2', 'hasta2', '85214796362');
INSERT INTO public.hasta_bilgileri (id, hasta_adi, hasta_soyadi, hasta_tc) VALUES (9, 'hasta3', 'hasta3', '95135748562');
INSERT INTO public.hasta_bilgileri (id, hasta_adi, hasta_soyadi, hasta_tc) VALUES (10, 'hasta4', 'hasta4', '65498732115');
INSERT INTO public.hasta_bilgileri (id, hasta_adi, hasta_soyadi, hasta_tc) VALUES (11, 'hasta1', 'hasta1', '1234567910');
INSERT INTO public.hasta_bilgileri (id, hasta_adi, hasta_soyadi, hasta_tc) VALUES (12, 'hasta5', 'hasta5', '62448652115');


--
-- TOC entry 3472 (class 0 OID 16755)
-- Dependencies: 222
-- Data for Name: ilac_bilgileri; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3474 (class 0 OID 16764)
-- Dependencies: 224
-- Data for Name: ilac_istekleri; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3478 (class 0 OID 16807)
-- Dependencies: 228
-- Data for Name: kan_istekleri; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3486 (class 0 OID 16870)
-- Dependencies: 236
-- Data for Name: klinik; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3484 (class 0 OID 16851)
-- Dependencies: 234
-- Data for Name: labaratuvar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.labaratuvar (id, doktor_id, hasta_id, sonuc, tarih) VALUES (4, 3, 7, 'sonuc1', '2021-03-20');


--
-- TOC entry 3488 (class 0 OID 16877)
-- Dependencies: 238
-- Data for Name: poliklinik; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3460 (class 0 OID 16665)
-- Dependencies: 210
-- Data for Name: randevu; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.randevu (id, hasta_adi, hasta_soyadi, hasta_tc, doktor_id, bolum_id, tarih) VALUES (22, 'hasta1', 'hasta1', '1234567910', 1, 2, '2021-12-10');
INSERT INTO public.randevu (id, hasta_adi, hasta_soyadi, hasta_tc, doktor_id, bolum_id, tarih) VALUES (23, 'hasta5', 'hasta5', '62448652115', 3, 3, '2021-12-03');


--
-- TOC entry 3509 (class 0 OID 0)
-- Dependencies: 231
-- Name: acil_servis_bos_yatak_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.acil_servis_bos_yatak_id_seq', 1, true);


--
-- TOC entry 3510 (class 0 OID 0)
-- Dependencies: 229
-- Name: acil_servis_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.acil_servis_id_seq', 7, true);


--
-- TOC entry 3511 (class 0 OID 0)
-- Dependencies: 219
-- Name: ameliyat_turu_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ameliyat_turu_id_seq', 4, true);


--
-- TOC entry 3512 (class 0 OID 0)
-- Dependencies: 217
-- Name: ameliyathane_bilgileri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ameliyathane_bilgileri_id_seq', 5, true);


--
-- TOC entry 3513 (class 0 OID 0)
-- Dependencies: 211
-- Name: bolumler_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.bolumler_id_seq', 6, true);


--
-- TOC entry 3514 (class 0 OID 0)
-- Dependencies: 213
-- Name: doktor_bilgileri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.doktor_bilgileri_id_seq', 3, true);


--
-- TOC entry 3515 (class 0 OID 0)
-- Dependencies: 225
-- Name: fatura_bilgileri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.fatura_bilgileri_id_seq', 11, true);


--
-- TOC entry 3516 (class 0 OID 0)
-- Dependencies: 215
-- Name: hasta_bilgileri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.hasta_bilgileri_id_seq', 12, true);


--
-- TOC entry 3517 (class 0 OID 0)
-- Dependencies: 221
-- Name: ilac_bilgileri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ilac_bilgileri_id_seq', 2, true);


--
-- TOC entry 3518 (class 0 OID 0)
-- Dependencies: 223
-- Name: ilac_istekleri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ilac_istekleri_id_seq', 5, true);


--
-- TOC entry 3519 (class 0 OID 0)
-- Dependencies: 227
-- Name: kan_istekleri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.kan_istekleri_id_seq', 1, true);


--
-- TOC entry 3520 (class 0 OID 0)
-- Dependencies: 235
-- Name: klinik_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.klinik_id_seq', 1, true);


--
-- TOC entry 3521 (class 0 OID 0)
-- Dependencies: 233
-- Name: labaratuvar_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.labaratuvar_id_seq', 4, true);


--
-- TOC entry 3522 (class 0 OID 0)
-- Dependencies: 237
-- Name: poliklinik_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.poliklinik_id_seq', 1, true);


--
-- TOC entry 3523 (class 0 OID 0)
-- Dependencies: 209
-- Name: randevu_bilgileri_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.randevu_bilgileri_id_seq', 23, true);


--
-- TOC entry 3289 (class 2606 OID 16845)
-- Name: acil_servis_bos_yatak acil_servis_bos_yatak_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.acil_servis_bos_yatak
    ADD CONSTRAINT acil_servis_bos_yatak_pkey PRIMARY KEY (id);


--
-- TOC entry 3287 (class 2606 OID 16833)
-- Name: acil_servis acil_servis_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.acil_servis
    ADD CONSTRAINT acil_servis_pkey PRIMARY KEY (id);


--
-- TOC entry 3275 (class 2606 OID 16740)
-- Name: ameliyat_turu ameliyat_turu_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ameliyat_turu
    ADD CONSTRAINT ameliyat_turu_pkey PRIMARY KEY (id);


--
-- TOC entry 3271 (class 2606 OID 16727)
-- Name: ameliyathane_bilgileri ameliyathane_bilgileri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ameliyathane_bilgileri
    ADD CONSTRAINT ameliyathane_bilgileri_pkey PRIMARY KEY (id);


--
-- TOC entry 3265 (class 2606 OID 16681)
-- Name: bolumler bolumler_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.bolumler
    ADD CONSTRAINT bolumler_pkey PRIMARY KEY (id);


--
-- TOC entry 3267 (class 2606 OID 16688)
-- Name: doktor_bilgileri doktor_bilgileri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.doktor_bilgileri
    ADD CONSTRAINT doktor_bilgileri_pkey PRIMARY KEY (id);


--
-- TOC entry 3283 (class 2606 OID 16793)
-- Name: fatura_bilgileri fatura_bilgileri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura_bilgileri
    ADD CONSTRAINT fatura_bilgileri_pkey PRIMARY KEY (id);


--
-- TOC entry 3269 (class 2606 OID 16709)
-- Name: hasta_bilgileri hasta_bilgileri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hasta_bilgileri
    ADD CONSTRAINT hasta_bilgileri_pkey PRIMARY KEY (id);


--
-- TOC entry 3277 (class 2606 OID 16762)
-- Name: ilac_bilgileri ilac_bilgileri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac_bilgileri
    ADD CONSTRAINT ilac_bilgileri_pkey PRIMARY KEY (id);


--
-- TOC entry 3281 (class 2606 OID 16769)
-- Name: ilac_istekleri ilac_istekleri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac_istekleri
    ADD CONSTRAINT ilac_istekleri_pkey PRIMARY KEY (id);


--
-- TOC entry 3285 (class 2606 OID 16814)
-- Name: kan_istekleri kan_istekleri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kan_istekleri
    ADD CONSTRAINT kan_istekleri_pkey PRIMARY KEY (id);


--
-- TOC entry 3294 (class 2606 OID 16875)
-- Name: klinik klinik_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.klinik
    ADD CONSTRAINT klinik_pkey PRIMARY KEY (id);


--
-- TOC entry 3291 (class 2606 OID 16858)
-- Name: labaratuvar labaratuvar_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.labaratuvar
    ADD CONSTRAINT labaratuvar_pkey PRIMARY KEY (id);


--
-- TOC entry 3296 (class 2606 OID 16882)
-- Name: poliklinik poliklinik_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.poliklinik
    ADD CONSTRAINT poliklinik_pkey PRIMARY KEY (id);


--
-- TOC entry 3263 (class 2606 OID 16672)
-- Name: randevu randevu_bilgileri_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu
    ADD CONSTRAINT randevu_bilgileri_pkey PRIMARY KEY (id);


--
-- TOC entry 3272 (class 1259 OID 16747)
-- Name: fki_ameliyat_id_fk; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_ameliyat_id_fk ON public.ameliyathane_bilgileri USING btree (ameliyat_id);


--
-- TOC entry 3260 (class 1259 OID 16700)
-- Name: fki_bolum_id_fk; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_bolum_id_fk ON public.randevu USING btree (bolum_id);


--
-- TOC entry 3261 (class 1259 OID 16694)
-- Name: fki_doktor_id_fk; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_doktor_id_fk ON public.randevu USING btree (doktor_id);


--
-- TOC entry 3278 (class 1259 OID 16780)
-- Name: fki_hasta_id_fk; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_hasta_id_fk ON public.ilac_istekleri USING btree (hasta_id);


--
-- TOC entry 3279 (class 1259 OID 16786)
-- Name: fki_ilac_id_fk; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_ilac_id_fk ON public.ilac_istekleri USING btree (istenilen_ilac_id);


--
-- TOC entry 3273 (class 1259 OID 16733)
-- Name: fki_randevu_bilgi_fk; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_randevu_bilgi_fk ON public.ameliyathane_bilgileri USING btree (randevu_id);


--
-- TOC entry 3292 (class 1259 OID 16888)
-- Name: fki_randevu_id_fk; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX fki_randevu_id_fk ON public.klinik USING btree (randevu_id);


--
-- TOC entry 3317 (class 2620 OID 16847)
-- Name: acil_servis acil_servis_bos_yatak; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER acil_servis_bos_yatak AFTER INSERT ON public.acil_servis FOR EACH ROW EXECUTE FUNCTION public.acil_servis_yatak();


--
-- TOC entry 3316 (class 2620 OID 16849)
-- Name: acil_servis acil_servis_hasta; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER acil_servis_hasta AFTER INSERT ON public.acil_servis FOR EACH ROW EXECUTE FUNCTION public.acil_servis_hasta();


--
-- TOC entry 3314 (class 2620 OID 16800)
-- Name: ameliyathane_bilgileri ameliyat_ucret_ekle; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER ameliyat_ucret_ekle AFTER INSERT ON public.ameliyathane_bilgileri FOR EACH ROW EXECUTE FUNCTION public.ameliyat_ucret_ekle();


--
-- TOC entry 3315 (class 2620 OID 16795)
-- Name: ilac_istekleri fatura_ekle; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER fatura_ekle AFTER INSERT ON public.ilac_istekleri FOR EACH ROW EXECUTE FUNCTION public.fatura_ekle();


--
-- TOC entry 3313 (class 2620 OID 16797)
-- Name: hasta_bilgileri fatura_olustur; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER fatura_olustur AFTER INSERT ON public.hasta_bilgileri FOR EACH ROW EXECUTE FUNCTION public.fatura_olustur();


--
-- TOC entry 3312 (class 2620 OID 16718)
-- Name: randevu hasta_e; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER hasta_e AFTER INSERT ON public.randevu FOR EACH ROW EXECUTE FUNCTION public.hasta_ekle();


--
-- TOC entry 3318 (class 2620 OID 16896)
-- Name: klinik klinik_ucret; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER klinik_ucret AFTER INSERT ON public.klinik FOR EACH ROW EXECUTE FUNCTION public.poliklinik_ucret();


--
-- TOC entry 3319 (class 2620 OID 16895)
-- Name: poliklinik poliklinik_ucret; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER poliklinik_ucret AFTER INSERT ON public.poliklinik FOR EACH ROW EXECUTE FUNCTION public.poliklinik_ucret();


--
-- TOC entry 3300 (class 2606 OID 16742)
-- Name: ameliyathane_bilgileri ameliyat_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ameliyathane_bilgileri
    ADD CONSTRAINT ameliyat_id_fk FOREIGN KEY (ameliyat_id) REFERENCES public.ameliyat_turu(id) NOT VALID;


--
-- TOC entry 3298 (class 2606 OID 16695)
-- Name: randevu bolum_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu
    ADD CONSTRAINT bolum_id_fk FOREIGN KEY (bolum_id) REFERENCES public.bolumler(id) NOT VALID;


--
-- TOC entry 3297 (class 2606 OID 16689)
-- Name: randevu doktor_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.randevu
    ADD CONSTRAINT doktor_id_fk FOREIGN KEY (doktor_id) REFERENCES public.doktor_bilgileri(id) NOT VALID;


--
-- TOC entry 3301 (class 2606 OID 16770)
-- Name: ilac_istekleri doktor_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac_istekleri
    ADD CONSTRAINT doktor_id_fk FOREIGN KEY (doktor_id) REFERENCES public.doktor_bilgileri(id) NOT VALID;


--
-- TOC entry 3305 (class 2606 OID 16815)
-- Name: kan_istekleri doktor_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kan_istekleri
    ADD CONSTRAINT doktor_id_fk FOREIGN KEY (doktor_id) REFERENCES public.doktor_bilgileri(id) NOT VALID;


--
-- TOC entry 3307 (class 2606 OID 16834)
-- Name: acil_servis doktor_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.acil_servis
    ADD CONSTRAINT doktor_id_fk FOREIGN KEY (doktor_id) REFERENCES public.doktor_bilgileri(id) NOT VALID;


--
-- TOC entry 3308 (class 2606 OID 16859)
-- Name: labaratuvar doktor_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.labaratuvar
    ADD CONSTRAINT doktor_id_fk FOREIGN KEY (doktor_id) REFERENCES public.doktor_bilgileri(id) NOT VALID;


--
-- TOC entry 3302 (class 2606 OID 16775)
-- Name: ilac_istekleri hasta_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac_istekleri
    ADD CONSTRAINT hasta_id_fk FOREIGN KEY (hasta_id) REFERENCES public.hasta_bilgileri(id) NOT VALID;


--
-- TOC entry 3306 (class 2606 OID 16820)
-- Name: kan_istekleri hasta_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.kan_istekleri
    ADD CONSTRAINT hasta_id_fk FOREIGN KEY (hasta_id) REFERENCES public.hasta_bilgileri(id) NOT VALID;


--
-- TOC entry 3309 (class 2606 OID 16864)
-- Name: labaratuvar hasta_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.labaratuvar
    ADD CONSTRAINT hasta_id_fk FOREIGN KEY (hasta_id) REFERENCES public.hasta_bilgileri(id) NOT VALID;


--
-- TOC entry 3304 (class 2606 OID 16897)
-- Name: fatura_bilgileri hasta_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fatura_bilgileri
    ADD CONSTRAINT hasta_id_fk FOREIGN KEY (hasta_id) REFERENCES public.hasta_bilgileri(id) NOT VALID;


--
-- TOC entry 3303 (class 2606 OID 16781)
-- Name: ilac_istekleri ilac_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ilac_istekleri
    ADD CONSTRAINT ilac_id_fk FOREIGN KEY (istenilen_ilac_id) REFERENCES public.ilac_bilgileri(id) NOT VALID;


--
-- TOC entry 3299 (class 2606 OID 16728)
-- Name: ameliyathane_bilgileri randevu_bilgi_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ameliyathane_bilgileri
    ADD CONSTRAINT randevu_bilgi_fk FOREIGN KEY (randevu_id) REFERENCES public.randevu(id) NOT VALID;


--
-- TOC entry 3310 (class 2606 OID 16883)
-- Name: klinik randevu_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.klinik
    ADD CONSTRAINT randevu_id_fk FOREIGN KEY (randevu_id) REFERENCES public.randevu(id) NOT VALID;


--
-- TOC entry 3311 (class 2606 OID 16889)
-- Name: poliklinik randevu_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.poliklinik
    ADD CONSTRAINT randevu_id_fk FOREIGN KEY (randevu_id) REFERENCES public.randevu(id) NOT VALID;


-- Completed on 2021-12-20 11:57:35

--
-- PostgreSQL database dump complete
--

