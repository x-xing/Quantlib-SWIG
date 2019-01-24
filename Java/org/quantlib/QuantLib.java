/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class QuantLib {
  public static Matrix transpose(Matrix m) {
    return new Matrix(QuantLibJNI.transpose(Matrix.getCPtr(m), m), true);
  }

  public static Matrix outerProduct(Array v1, Array v2) {
    return new Matrix(QuantLibJNI.outerProduct(Array.getCPtr(v1), v1, Array.getCPtr(v2), v2), true);
  }

  public static Matrix pseudoSqrt(Matrix m, SalvagingAlgorithm.Type a) {
    return new Matrix(QuantLibJNI.pseudoSqrt(Matrix.getCPtr(m), m, a.swigValue()), true);
  }

  public static int nullInt() {
    return QuantLibJNI.nullInt();
  }

  public static double nullDouble() {
    return QuantLibJNI.nullDouble();
  }

  public static DayCounter Actual365NoLeap() {
    return new DayCounter(QuantLibJNI.Actual365NoLeap(), true);
  }

  public static IborIndex as_iborindex(InterestRateIndex index) {
    return new IborIndex(QuantLibJNI.as_iborindex(InterestRateIndex.getCPtr(index), index), true);
  }

  public static GsrProcess as_gsr_process(StochasticProcess proc) {
    return new GsrProcess(QuantLibJNI.as_gsr_process(StochasticProcess.getCPtr(proc), proc), true);
  }

  public static Coupon as_coupon(CashFlow cf) {
    return new Coupon(QuantLibJNI.as_coupon(CashFlow.getCPtr(cf), cf), true);
  }

  public static FixedRateCoupon as_fixed_rate_coupon(CashFlow cf) {
    return new FixedRateCoupon(QuantLibJNI.as_fixed_rate_coupon(CashFlow.getCPtr(cf), cf), true);
  }

  public static void setCouponPricer(Leg arg0, FloatingRateCouponPricer arg1) {
    QuantLibJNI.setCouponPricer(Leg.getCPtr(arg0), arg0, FloatingRateCouponPricer.getCPtr(arg1), arg1);
  }

  public static FloatingRateCoupon as_floating_rate_coupon(CashFlow cf) {
    return new FloatingRateCoupon(QuantLibJNI.as_floating_rate_coupon(CashFlow.getCPtr(cf), cf), true);
  }

  public static Leg FixedRateLeg(Schedule schedule, DayCounter dayCount, DoubleVector nominals, DoubleVector couponRates, BusinessDayConvention paymentAdjustment, DayCounter firstPeriodDayCount) {
    return new Leg(QuantLibJNI.FixedRateLeg__SWIG_0(Schedule.getCPtr(schedule), schedule, DayCounter.getCPtr(dayCount), dayCount, DoubleVector.getCPtr(nominals), nominals, DoubleVector.getCPtr(couponRates), couponRates, paymentAdjustment.swigValue(), DayCounter.getCPtr(firstPeriodDayCount), firstPeriodDayCount), true);
  }

  public static Leg FixedRateLeg(Schedule schedule, DayCounter dayCount, DoubleVector nominals, DoubleVector couponRates, BusinessDayConvention paymentAdjustment) {
    return new Leg(QuantLibJNI.FixedRateLeg__SWIG_1(Schedule.getCPtr(schedule), schedule, DayCounter.getCPtr(dayCount), dayCount, DoubleVector.getCPtr(nominals), nominals, DoubleVector.getCPtr(couponRates), couponRates, paymentAdjustment.swigValue()), true);
  }

  public static Leg FixedRateLeg(Schedule schedule, DayCounter dayCount, DoubleVector nominals, DoubleVector couponRates) {
    return new Leg(QuantLibJNI.FixedRateLeg__SWIG_2(Schedule.getCPtr(schedule), schedule, DayCounter.getCPtr(dayCount), dayCount, DoubleVector.getCPtr(nominals), nominals, DoubleVector.getCPtr(couponRates), couponRates), true);
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors, boolean isInArrears) {
    return new Leg(QuantLibJNI.IborLeg__SWIG_0(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, IborIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads, DoubleVector.getCPtr(caps), caps, DoubleVector.getCPtr(floors), floors, isInArrears), true);
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors) {
    return new Leg(QuantLibJNI.IborLeg__SWIG_1(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, IborIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads, DoubleVector.getCPtr(caps), caps, DoubleVector.getCPtr(floors), floors), true);
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps) {
    return new Leg(QuantLibJNI.IborLeg__SWIG_2(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, IborIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads, DoubleVector.getCPtr(caps), caps), true);
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads) {
    return new Leg(QuantLibJNI.IborLeg__SWIG_3(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, IborIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads), true);
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings) {
    return new Leg(QuantLibJNI.IborLeg__SWIG_4(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, IborIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings), true);
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays) {
    return new Leg(QuantLibJNI.IborLeg__SWIG_5(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, IborIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays), true);
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention) {
    return new Leg(QuantLibJNI.IborLeg__SWIG_6(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, IborIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue()), true);
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index, DayCounter paymentDayCounter) {
    return new Leg(QuantLibJNI.IborLeg__SWIG_7(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, IborIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter), true);
  }

  public static Leg IborLeg(DoubleVector nominals, Schedule schedule, IborIndex index) {
    return new Leg(QuantLibJNI.IborLeg__SWIG_8(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, IborIndex.getCPtr(index), index), true);
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors, boolean isInArrears) {
    return new Leg(QuantLibJNI.CmsLeg__SWIG_0(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads, DoubleVector.getCPtr(caps), caps, DoubleVector.getCPtr(floors), floors, isInArrears), true);
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors) {
    return new Leg(QuantLibJNI.CmsLeg__SWIG_1(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads, DoubleVector.getCPtr(caps), caps, DoubleVector.getCPtr(floors), floors), true);
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps) {
    return new Leg(QuantLibJNI.CmsLeg__SWIG_2(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads, DoubleVector.getCPtr(caps), caps), true);
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads) {
    return new Leg(QuantLibJNI.CmsLeg__SWIG_3(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads), true);
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings) {
    return new Leg(QuantLibJNI.CmsLeg__SWIG_4(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings), true);
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays) {
    return new Leg(QuantLibJNI.CmsLeg__SWIG_5(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays), true);
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention) {
    return new Leg(QuantLibJNI.CmsLeg__SWIG_6(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue()), true);
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter) {
    return new Leg(QuantLibJNI.CmsLeg__SWIG_7(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter), true);
  }

  public static Leg CmsLeg(DoubleVector nominals, Schedule schedule, SwapIndex index) {
    return new Leg(QuantLibJNI.CmsLeg__SWIG_8(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index), true);
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps, DoubleVector floors) {
    return new Leg(QuantLibJNI.CmsZeroLeg__SWIG_0(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads, DoubleVector.getCPtr(caps), caps, DoubleVector.getCPtr(floors), floors), true);
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads, DoubleVector caps) {
    return new Leg(QuantLibJNI.CmsZeroLeg__SWIG_1(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads, DoubleVector.getCPtr(caps), caps), true);
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings, DoubleVector spreads) {
    return new Leg(QuantLibJNI.CmsZeroLeg__SWIG_2(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings, DoubleVector.getCPtr(spreads), spreads), true);
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays, DoubleVector gearings) {
    return new Leg(QuantLibJNI.CmsZeroLeg__SWIG_3(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays, DoubleVector.getCPtr(gearings), gearings), true);
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention, UnsignedIntVector fixingDays) {
    return new Leg(QuantLibJNI.CmsZeroLeg__SWIG_4(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue(), UnsignedIntVector.getCPtr(fixingDays), fixingDays), true);
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter, BusinessDayConvention paymentConvention) {
    return new Leg(QuantLibJNI.CmsZeroLeg__SWIG_5(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter, paymentConvention.swigValue()), true);
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index, DayCounter paymentDayCounter) {
    return new Leg(QuantLibJNI.CmsZeroLeg__SWIG_6(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index, DayCounter.getCPtr(paymentDayCounter), paymentDayCounter), true);
  }

  public static Leg CmsZeroLeg(DoubleVector nominals, Schedule schedule, SwapIndex index) {
    return new Leg(QuantLibJNI.CmsZeroLeg__SWIG_7(DoubleVector.getCPtr(nominals), nominals, Schedule.getCPtr(schedule), schedule, SwapIndex.getCPtr(index), index), true);
  }

  public static double blackFormula(Option.Type optionType, double strike, double forward, double stdDev, double discount, double displacement) {
    return QuantLibJNI.blackFormula__SWIG_0(optionType.swigValue(), strike, forward, stdDev, discount, displacement);
  }

  public static double blackFormula(Option.Type optionType, double strike, double forward, double stdDev, double discount) {
    return QuantLibJNI.blackFormula__SWIG_1(optionType.swigValue(), strike, forward, stdDev, discount);
  }

  public static double blackFormula(Option.Type optionType, double strike, double forward, double stdDev) {
    return QuantLibJNI.blackFormula__SWIG_2(optionType.swigValue(), strike, forward, stdDev);
  }

  public static double blackFormulaImpliedStdDev(Option.Type optionType, double strike, double forward, double blackPrice, double discount, double displacement, double guess, double accuracy, long maxIterations) {
    return QuantLibJNI.blackFormulaImpliedStdDev__SWIG_0(optionType.swigValue(), strike, forward, blackPrice, discount, displacement, guess, accuracy, maxIterations);
  }

  public static double blackFormulaImpliedStdDev(Option.Type optionType, double strike, double forward, double blackPrice, double discount, double displacement, double guess, double accuracy) {
    return QuantLibJNI.blackFormulaImpliedStdDev__SWIG_1(optionType.swigValue(), strike, forward, blackPrice, discount, displacement, guess, accuracy);
  }

  public static double blackFormulaImpliedStdDev(Option.Type optionType, double strike, double forward, double blackPrice, double discount, double displacement, double guess) {
    return QuantLibJNI.blackFormulaImpliedStdDev__SWIG_2(optionType.swigValue(), strike, forward, blackPrice, discount, displacement, guess);
  }

  public static double blackFormulaImpliedStdDev(Option.Type optionType, double strike, double forward, double blackPrice, double discount, double displacement) {
    return QuantLibJNI.blackFormulaImpliedStdDev__SWIG_3(optionType.swigValue(), strike, forward, blackPrice, discount, displacement);
  }

  public static double blackFormulaImpliedStdDev(Option.Type optionType, double strike, double forward, double blackPrice, double discount) {
    return QuantLibJNI.blackFormulaImpliedStdDev__SWIG_4(optionType.swigValue(), strike, forward, blackPrice, discount);
  }

  public static double blackFormulaImpliedStdDev(Option.Type optionType, double strike, double forward, double blackPrice) {
    return QuantLibJNI.blackFormulaImpliedStdDev__SWIG_5(optionType.swigValue(), strike, forward, blackPrice);
  }

  public static double blackFormulaCashItmProbability(Option.Type optionType, double strike, double forward, double stdDev, double displacement) {
    return QuantLibJNI.blackFormulaCashItmProbability__SWIG_0(optionType.swigValue(), strike, forward, stdDev, displacement);
  }

  public static double blackFormulaCashItmProbability(Option.Type optionType, double strike, double forward, double stdDev) {
    return QuantLibJNI.blackFormulaCashItmProbability__SWIG_1(optionType.swigValue(), strike, forward, stdDev);
  }

  public static double bachelierBlackFormula(Option.Type optionType, double strike, double forward, double stdDev, double discount) {
    return QuantLibJNI.bachelierBlackFormula__SWIG_0(optionType.swigValue(), strike, forward, stdDev, discount);
  }

  public static double bachelierBlackFormula(Option.Type optionType, double strike, double forward, double stdDev) {
    return QuantLibJNI.bachelierBlackFormula__SWIG_1(optionType.swigValue(), strike, forward, stdDev);
  }

  public static double bachelierBlackFormulaImpliedVol(Option.Type optionType, double strike, double forward, double tte, double bachelierPrice, double discount) {
    return QuantLibJNI.bachelierBlackFormulaImpliedVol__SWIG_0(optionType.swigValue(), strike, forward, tte, bachelierPrice, discount);
  }

  public static double bachelierBlackFormulaImpliedVol(Option.Type optionType, double strike, double forward, double tte, double bachelierPrice) {
    return QuantLibJNI.bachelierBlackFormulaImpliedVol__SWIG_1(optionType.swigValue(), strike, forward, tte, bachelierPrice);
  }

  public static Date inflationBaseDate(Date referenceDate, Period observationLag, Frequency frequency, boolean indexIsInterpolated) {
    return new Date(QuantLibJNI.inflationBaseDate(Date.getCPtr(referenceDate), referenceDate, Period.getCPtr(observationLag), observationLag, frequency.swigValue(), indexIsInterpolated), true);
  }

  public static double cleanPriceFromZSpread(Bond bond, YieldTermStructure discountCurve, double zSpread, DayCounter dc, Compounding compounding, Frequency freq, Date settlementDate) {
    return QuantLibJNI.cleanPriceFromZSpread__SWIG_0(Bond.getCPtr(bond), bond, YieldTermStructure.getCPtr(discountCurve), discountCurve, zSpread, DayCounter.getCPtr(dc), dc, compounding.swigValue(), freq.swigValue(), Date.getCPtr(settlementDate), settlementDate);
  }

  public static double cleanPriceFromZSpread(Bond bond, YieldTermStructure discountCurve, double zSpread, DayCounter dc, Compounding compounding, Frequency freq) {
    return QuantLibJNI.cleanPriceFromZSpread__SWIG_1(Bond.getCPtr(bond), bond, YieldTermStructure.getCPtr(discountCurve), discountCurve, zSpread, DayCounter.getCPtr(dc), dc, compounding.swigValue(), freq.swigValue());
  }

  public static DepositRateHelper as_depositratehelper(RateHelper helper) {
    return new DepositRateHelper(QuantLibJNI.as_depositratehelper(RateHelper.getCPtr(helper), helper), true);
  }

  public static FraRateHelper as_fraratehelper(RateHelper helper) {
    return new FraRateHelper(QuantLibJNI.as_fraratehelper(RateHelper.getCPtr(helper), helper), true);
  }

  public static SwapRateHelper as_swapratehelper(RateHelper helper) {
    return new SwapRateHelper(QuantLibJNI.as_swapratehelper(RateHelper.getCPtr(helper), helper), true);
  }

  public static OISRateHelper as_oisratehelper(RateHelper helper) {
    return new OISRateHelper(QuantLibJNI.as_oisratehelper(RateHelper.getCPtr(helper), helper), true);
  }

  public static Matrix getCovariance(Array volatilities, Matrix correlations) {
    return new Matrix(QuantLibJNI.getCovariance(Array.getCPtr(volatilities), volatilities, Matrix.getCPtr(correlations), correlations), true);
  }

  public static void enableTracing() {
    QuantLibJNI.enableTracing();
  }

  public static void disableTracing() {
    QuantLibJNI.disableTracing();
  }

  public static ZeroCurve as_zerocurve(YieldTermStructure curve) {
    return new ZeroCurve(QuantLibJNI.as_zerocurve(YieldTermStructure.getCPtr(curve), curve), true);
  }

}
